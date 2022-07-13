using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    public Rigidbody rid;
    public CheckColider DeadLine;
    public MoveBrush Lscript,Rscript;

    Vector3 Kip;
    float LeftP,RightP;
    public void LeftUp()
    {
        Lscript.check = true;
        Left.SetActive(false);
        LeftP = 0;
    }
    public void LeftDown()
    {
        if(DeadLine.StartLine == true){
            Left.SetActive(true);
            LeftP = -0.005f;
        }
    }
    public void RightUp()
    {
        Rscript.check = true;
        Right.SetActive(false);
         RightP = 0;
    }
    public void RightDown()
    {
        if(DeadLine.StartLine == true){
            Right.SetActive(true);
            RightP = 0.005f;
        }
    }
    private void Start()
    {
        StartCoroutine(s());
    }
    IEnumerator s()
    {
        while(true)
        {
            if (DeadLine.DeadLine == true)
            {
                Destroy(Right);
                Destroy(Left);
                Destroy(this.gameObject);
            }

            if (RightP + LeftP != 0)
            {
                Kip = rid.velocity;
                rid.velocity += new Vector3(Kip.z * (LeftP + RightP), 0, Kip.z * 0.001f);
            }

            yield return new WaitForSeconds(0.05f);
        }
        
    }
}
