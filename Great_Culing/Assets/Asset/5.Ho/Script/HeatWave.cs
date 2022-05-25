using UnityEngine;

[RequireComponent(typeof(Camera))]
public class HeatWave : MonoBehaviour
{
	[Range(0.003f, 0.02f)] public float m_Strength = 0.01f;
	public Material m_MatHeatWave;
	public bool m_ShowInternalMaps = false;
	[Header("Internal")]
	private LayerMask m_LmHeatWave;
	public Shader m_SdrDepthOnly;
	public RenderTexture m_RTMask;
	public Camera m_RTCamera;
	public GameObject m_RTCameraGo;

	void Start ()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			enabled = false;
			return;
		}
		m_LmHeatWave = LayerMask.NameToLayer ("TransparentFX");
		m_RTMask = new RenderTexture (Screen.width, Screen.height, 16);
		m_RTMask.hideFlags = HideFlags.DontSave;
		m_SdrDepthOnly = Shader.Find ("Heat Wave/Depth Only");
	}
	void Update ()
	{
		Camera camCurr = Camera.main;
		if (m_RTCamera == null)
		{
			m_RTCameraGo = new GameObject ("Mask Camera", typeof (Camera));
			m_RTCameraGo.hideFlags = HideFlags.DontSave;
			m_RTCamera = m_RTCameraGo.GetComponent<Camera> ();
		}
		m_RTCamera.CopyFrom (camCurr);
		m_RTCamera.enabled = false;

		// first pass, geometry depth only pass
		m_RTCamera.targetTexture = m_RTMask;
		m_RTCamera.cullingMask = ~(1 << m_LmHeatWave);
		m_RTCamera.clearFlags = CameraClearFlags.SolidColor;
		m_RTCamera.backgroundColor = new Color (0.5f, 0.5f, 1f);
		m_RTCamera.RenderWithShader (m_SdrDepthOnly, "");

		// second pass, render stuff to distortion map
		m_RTCamera.cullingMask = 1 << m_LmHeatWave;
		m_RTCamera.clearFlags = CameraClearFlags.Nothing;
		m_RTCamera.Render ();
	}
	void OnDisable ()
	{
		if (m_RTCamera)
		{
			DestroyImmediate (m_RTCamera);
			m_RTCamera = null;
		}
		if (m_RTCameraGo)
		{
			DestroyImmediate (m_RTCameraGo);
			m_RTCameraGo = null;
		}
	}
	void OnRenderImage (RenderTexture src, RenderTexture dst)
	{
		m_MatHeatWave.SetFloat ("_Strength", m_Strength);
		m_MatHeatWave.SetTexture ("_DistortionTex", m_RTMask);
		Graphics.Blit (src, dst, m_MatHeatWave);
	}
	void OnGUI ()
	{
		if (m_ShowInternalMaps)
			GUI.DrawTextureWithTexCoords (new Rect (10, 10, 128, 128), m_RTMask, new Rect (0, 0, 1, 1));
	}
}