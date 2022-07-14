using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSet : MonoBehaviour
{
    public static BallSet inc;

    private void Awake()
    {
        if (inc == null)
        {
            inc = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    public GameObject[] BlueStone;
    public GameObject[] RedStone;

    public int bgmCnt;
}
