using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBtn : MonoBehaviour
{
    public GameObject blue,red;

    // Start is called before the first frame update
    public void Click()
    {
        Destroy(this.gameObject);
        if(VariableMng.VRBMNG.RedandBlueTurn == true)
        {
            Instantiate(blue);
        }
        else
        {
            Instantiate(red);
        }
    }
}
