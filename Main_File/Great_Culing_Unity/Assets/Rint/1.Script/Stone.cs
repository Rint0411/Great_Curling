using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public Transform rid;
    Vector3 position;
    public GameObject blue,red,ScoreB,Ending,sound;
    
    bool o;

    void FixedUpdate()
    {
        if(VariableMng.VRBMNG.Start == true)
        {
            if(rid.position == position)
            {
                VariableMng.VRBMNG.Start = false;
                VariableMng.VRBMNG.RedandBlueTurn = !VariableMng.VRBMNG.RedandBlueTurn;
                Invoke("Stop",0.1f);
            }
            position = rid.position;
        }
    }
    void Stop()
    {
        sound.SetActive(false);
        VariableMng.VRBMNG.CameraSet.SetActive(true);
        if(VariableMng.VRBMNG.Turn == 9||VariableMng.VRBMNG.Turn == 18|| VariableMng.VRBMNG.Turn == 27) 
        {
            for(int i =0; i<4;i++)
            {
                o = true;
                for(int j =0; j<4;j++)
                {
                    if((double)VariableMng.VRBMNG.SetScoreBlue[i]>=(double)VariableMng.VRBMNG.SetScoreRed[j])
                    {
                        o = false;
                    }
                    
                }

                if(o ==true)
                {
                    VariableMng.VRBMNG.ScoreBlue[VariableMng.VRBMNG.Round] +=1;
                }

                o = true;

                for(int j =0; j<4;j++)
                {
                    if((double)VariableMng.VRBMNG.SetScoreRed[i]>=(double)VariableMng.VRBMNG.SetScoreBlue[j]){
                        o = false;
                    }
                    
                }
                if(o ==true)
                {
                    VariableMng.VRBMNG.ScoreRed[VariableMng.VRBMNG.Round] +=1;
                }
                
            }
            VariableMng.VRBMNG.Blue +=  VariableMng.VRBMNG.ScoreBlue[VariableMng.VRBMNG.Round];
            VariableMng.VRBMNG.Red +=  VariableMng.VRBMNG.ScoreRed[VariableMng.VRBMNG.Round];


            if(VariableMng.VRBMNG.Turn == 18)
            {
                if(Mathf.Abs(VariableMng.VRBMNG.Blue-VariableMng.VRBMNG.Red) >= 5)
                {
                    Instantiate(Ending);
                }
                else
                {
                    Instantiate(ScoreB);
                }
            }else if(VariableMng.VRBMNG.Turn == 9) 
            {
                Instantiate(ScoreB);
            }
            else
            {
                Instantiate(Ending);
            }
            
        }
        else{
            if(VariableMng.VRBMNG.RedandBlueTurn == true)
            {
                Instantiate(blue);
            }
            else
            {
                Instantiate(red);
            }
        }
        
        Destroy(this.gameObject);
    }
}
