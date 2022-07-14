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
        SoundMng.instance.PlaySe(0);
        VariableMng.VRBMNG.CameraSet.SetActive(Check);
        VariableMng.VRBMNG.gpoint = !VariableMng.VRBMNG.gpoint;
        Camera.SetActive(!Check);
        Check = !Check;
    }
}
