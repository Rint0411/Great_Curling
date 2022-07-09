Shader "Heat Wave/Distortion" {
	Properties {
		_MainTex ("Main", 2D) = "black" {}
		_DistortionTex ("Distortion", 2D) = "black" {}
		_Strength ("Strength", Float) = 0.1
	}
	SubShader {
		ZTest Always Cull Off ZWrite Off Fog { Mode Off }
		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#include "UnityCG.cginc"
			sampler2D _MainTex, _DistortionTex;
			float _Strength;

			fixed4 frag (v2f_img i) : COLOR
			{
				float2 uv = i.uv;
//				uv.y = 1 - uv.y;
				float3 bump = normalize(tex2D(_DistortionTex, uv).rgb - 0.5);
				float2 offset = refract(fixed3(0, 0, 1), bump, 1).xy * _Strength;
				return tex2D(_MainTex, i.uv + offset);
			}
			ENDCG
		}
	}
	Fallback Off
}
