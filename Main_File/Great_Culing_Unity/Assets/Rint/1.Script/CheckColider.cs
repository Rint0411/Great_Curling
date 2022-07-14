using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColider : MonoBehaviour
{
    
    public bool DeadLine,team,checking = false,LineCheck = false, StartLine;
    bool g = false;
    [Header("체크 시 블루")]
    public GameObject gpoint;

    int round;
    private void Start()
    {
        round = VariableMng.VRBMNG.Round;
    }
    private void FixedUpdate()
    {
        if(VariableMng.VRBMNG.gpoint == true && gpoint.activeSelf == false)
        {
            gpoint.SetActive(true);
        }
        else if(VariableMng.VRBMNG.gpoint == false && gpoint.activeSelf == true)
        {
            gpoint.SetActive(false);
        }
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Rock"))
        {
            SoundMng.instance.PlaySe(6);
        }
        if (g == false)
        {
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX| RigidbodyConstraints.FreezeRotationZ;
            g = true;
        }
        if (collision.transform.CompareTag("Stone"))
        {
            SoundMng.instance.PlaySe(5);
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
