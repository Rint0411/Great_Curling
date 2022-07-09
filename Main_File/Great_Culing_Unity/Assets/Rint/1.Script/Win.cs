using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text t1,t2,main;
    public GameObject Map,NextMap;

    private void Start()
    {
        Map = GameObject.Find("InGame_Bongyang(Clone)");
    }
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
        Instantiate(NextMap);
        Destroy(Map);Destroy(this.gameObject);
    }
}
