using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private static int gold = 10000;
    public bool[] IsBuy;

    public static int Gold
    {
        get
        {
            return gold;
        }
        set
        { 
            gold = value;
            if(gold < 0)
            {
                gold = 0;
            }
            PlayerPrefs.SetInt("gold",gold);
        }
    }
}
