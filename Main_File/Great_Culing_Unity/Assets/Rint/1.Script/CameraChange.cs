using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject Canvas, Camera;
    bool Check = false;
    public void Onbtn()
    {
        Canvas.SetActive(Check);
        VariableMng.VRBMNG.CameraSet.SetActive(Check);
        Camera.SetActive(!Check);
        Check = !Check;
    }
}
