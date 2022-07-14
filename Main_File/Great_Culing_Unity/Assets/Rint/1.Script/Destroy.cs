using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Update()
    {
        if(VariableMng.VRBMNG.check == true)
        {
            Destroy(this.gameObject);
        }
    }
}
