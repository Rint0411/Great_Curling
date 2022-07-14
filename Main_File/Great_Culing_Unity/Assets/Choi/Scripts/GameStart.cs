using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Gamestart;
    public GameObject Title;
    public void OnClickStart()
    {
        Gamemanager.Gold = PlayerPrefs.GetInt("gold");
        for(int i = 0; i < Gamemanager.StoneCnt; i++)
        {
            if(PlayerPrefs.GetInt("IsBuy" + i) == 1)
            {
                Gamemanager.IsBuy[i] = true;
            }
        }
        GameObject GameStart = Instantiate(Gamestart);
        SoundMng.instance.PlaySe(0);
        Destroy(Title);     
    }
    public void Start()
    {
        SoundMng.instance.PlayBgm(0);
    }
}
