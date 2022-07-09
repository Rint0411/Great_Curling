using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    public Text Cnt1,Cnt2,AllCnt1,AllCnt2;
    public GameObject Red,Blue,Random;

    void Update()
    {
        Cnt1.text = VariableMng.VRBMNG.ScoreBlue[VariableMng.VRBMNG.Round]+"";
        Cnt2.text = VariableMng.VRBMNG.ScoreRed[VariableMng.VRBMNG.Round]+"";
        AllCnt1.text = VariableMng.VRBMNG.Blue+"";
        AllCnt2.text = VariableMng.VRBMNG.Red+"";
    }
    public void Next()
    {
        for(int i =0; i<4; i++)
        {
            VariableMng.VRBMNG.SetScoreRed[i] = 10;
            VariableMng.VRBMNG.SetScoreBlue[i] = 10;
        }
        
        if(VariableMng.VRBMNG.ScoreRed[VariableMng.VRBMNG.Round]>VariableMng.VRBMNG.ScoreBlue[VariableMng.VRBMNG.Round])
        {
            VariableMng.VRBMNG.RedandBlueTurn = false;
            Instantiate(Red);
        }else if(VariableMng.VRBMNG.ScoreRed[VariableMng.VRBMNG.Round] < VariableMng.VRBMNG.ScoreBlue[VariableMng.VRBMNG.Round])
        {
            VariableMng.VRBMNG.RedandBlueTurn= true;
            Instantiate(Blue);
        }else Instantiate(Random);
        
        VariableMng.VRBMNG.Round+=1;
        
        VariableMng.VRBMNG.Turn+=1;
        Destroy(this.gameObject);
    }
}
