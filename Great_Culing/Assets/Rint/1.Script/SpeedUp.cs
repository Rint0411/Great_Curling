using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public Rigidbody rid;
    public CheckColider DeadLine;

    Vector3 Kip;
    float LeftP,RightP;
    public void LeftUp()
    {
        Left.SetActive(false);
        LeftP = 0;
    }
    public void LeftDown()
    {
        if(DeadLine.StartLine == true){
            Left.SetActive(true);
            LeftP = -0.0015f;
        }
    }
    public void RightUp()
    {
        Right.SetActive(false);
         RightP = 0;
    }
    public void RightDown()
    {
        if(DeadLine.StartLine == true){
            Right.SetActive(true);
            RightP = 0.0015f;
        }
    }

    private void Update()
    {
        
        if(DeadLine.DeadLine == true)
        {
            Destroy(Right);
            Destroy(Left);
            Destroy(this.gameObject);
        }

        if(RightP+LeftP!=0)
        {
            Kip = rid.velocity;
            rid.velocity += new Vector3(Kip.z*(LeftP+RightP),0,Kip.z*0.001f);
        }
    }
}
