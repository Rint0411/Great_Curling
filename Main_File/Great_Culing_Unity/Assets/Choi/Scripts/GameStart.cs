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
        SoundMng.instance.PlaySe(0);
        Destroy(Title);     
    }
    public void Start()
    {
        SoundMng.instance.PlayBgm(0);
    }
}
