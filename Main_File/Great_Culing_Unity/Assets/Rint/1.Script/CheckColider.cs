using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColider : MonoBehaviour
{
    public bool DeadLine,team,checking = false,LineCheck = false, StartLine;

    int round;
    private void Start()
    {
        round = VariableMng.VRBMNG.Round;
    }
    private void FixedUpdate()
    {
        if(round != VariableMng.VRBMNG.Round)
        {
            Destroy(this.gameObject);
        }
        if(team != VariableMng.VRBMNG.RedandBlueTurn && LineCheck == false)
        {
            if(DeadLine != true)Destroy(this.gameObject, 0.5f);
            LineCheck = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("DeadLine"))
        {
            DeadLine = true;
        }
        if(other.CompareTag("StartLine"))
        {
            StartLine = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("SafeArea"))
        {
            if(checking == false)
            if(VariableMng.VRBMNG.Turn == 9 || VariableMng.VRBMNG.Turn == 18 || VariableMng.VRBMNG.Turn == 27) 
            {
                if(team == true)
                {
                    for(int i =0; i<4;i++){
                        if(VariableMng.VRBMNG.SetScoreBlue[i] == 10){
                            VariableMng.VRBMNG.SetScoreBlue[i] =  Vector3.Distance( VariableMng.VRBMNG.Point.position, transform.position);
                            break;
                        }
                        
                    }
                    
                }
                else
                {
                    for(int i =0; i<4;i++){
                        if(VariableMng.VRBMNG.SetScoreRed[i] == 10){
                            VariableMng.VRBMNG.SetScoreRed[i] =  Vector3.Distance( VariableMng.VRBMNG.Point.position, transform.position);
                            break;
                        }
                        
                    }
                }
                checking = true;
            }
        }
    }
}
