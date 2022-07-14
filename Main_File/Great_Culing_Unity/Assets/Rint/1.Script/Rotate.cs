using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject on,on2;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("next", 2);
        VariableMng.VRBMNG.check = false;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, 45*Time.deltaTime, 0);
    }

    void next()
    {
        on.SetActive(true); on2.SetActive(true);
        Destroy(this.gameObject);

    }
}
