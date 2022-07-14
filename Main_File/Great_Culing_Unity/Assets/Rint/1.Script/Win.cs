using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text t1,t2,main;
    public GameObject NextMap;

    void Update()
    {
        t1.text = VariableMng.VRBMNG.Blue+"";
        t2.text = VariableMng.VRBMNG.Red+"";
        if(VariableMng.VRBMNG.Blue>VariableMng.VRBMNG.Red)
        {
            main.text = "BLUE 승리";
        }else if(VariableMng.VRBMNG.Blue<VariableMng.VRBMNG.Red)
        {
            main.text = "RED 승리";
        }else
        {
            main.text = "무승부";
        }
    }
    public void Next()
    {
        SoundMng.instance.PlaySe(0);
        Gamemanager.Gold += 200;
        Instantiate(NextMap);
        VariableMng.VRBMNG.check = true; Destroy(this.gameObject);
    }
}
