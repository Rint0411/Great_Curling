using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableMng : MonoBehaviour
{
    public static VariableMng VRBMNG;

    private void Awake()
    {
        if (VRBMNG == null)
        { 
            VRBMNG = this; 
            DontDestroyOnLoad(gameObject);
        }

        Time.timeScale = 0.7F;
    }
    
    public int[] ScoreBlue = new int[3];
    public int[] ScoreRed = new int[3];
    public float[] SetScoreRed = new float[4];
    public float[] SetScoreBlue = new float[4];


    public bool RedandBlueTurn = true; // 파랑팀
    public int Turn = 1,Round,Red,Blue;
    public bool check = false;
    //9 18 정산 무승부 시 3라운드 27정산 그 후 무승부 그냥 무승부로 처리
    //이긴 쪽이 정산 후 선공
    public bool Start = false;
    public GameObject CameraSet;
    public Transform Point;
    public bool gpoint = false;
}
