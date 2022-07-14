using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneMove : MonoBehaviour
{
    public GameObject[] Scene;
    public bool check = false;
    public void SceneMove(int count)
    {
        if (check == true)
            VariableMng.VRBMNG.check = true;

        SoundMng.instance.PlaySe(0);
        Instantiate(Scene[count]);
        Destroy(this.gameObject);
    }
}
