using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBtn : MonoBehaviour
{
    public GameObject blue,red,btn;
    private void Start()
    {
        Invoke("Next", 0.5f);
    }
    void Next()
    {
        btn.SetActive(true);
    }
    // Start is called before the first frame update
    public void Click()
    {
        SoundMng.instance.PlaySe(0);
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
