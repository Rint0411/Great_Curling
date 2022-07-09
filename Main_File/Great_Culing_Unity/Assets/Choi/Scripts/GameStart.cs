using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Gamestart;
    public GameObject Title;
    public void OnClickStart()
    {
        GameObject GameStart = Instantiate(Gamestart);
        Destroy(Title);     
    }
}
