using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject popup;
    [SerializeField] GameObject _Map;
    [SerializeField] GameObject gameStart_text;
    [SerializeField] GameObject Maps,Main;

    public void off_select()
    {
        popup.SetActive(false);
        MapselectManager.instance.mapbig[(int)MapselectManager.instance.NowState].GetComponent<Map_Big>().Big_Stop();
        SoundMng.instance.PlaySe(0);
    }
    public void start_game()
    {
        off_select();
        Instantiate(MapselectManager.instance.Maps[(int)MapselectManager.instance.NowState]);
        Maps.SetActive(false);
        Destroy(Main);
        SoundMng.instance.PlayBgm(BallSet.inc.bgmCnt);
        SoundMng.instance.PlaySe(2);
    }
    public void select_AnGae(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.AnGae);
        BallSet.inc.bgmCnt = Cnt;
    }
    public void select_Anpyeong(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.Anpyeong);
        BallSet.inc.bgmCnt = Cnt;
    }
    public void select_AnSa(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.AnSa); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_BiAn(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.BiAn); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_BongYang(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.BongYang); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_ChonSan(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.ChonSan); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_DaIn(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DaIn); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_DanBuk(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DanBuk); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_DanChon(int Cnt)
    {
        BallSet.inc.bgmCnt = Cnt;
        MapselectManager.instance.setMap(MapselectManager.MapState.DanChon);
    }
    public void select_DanMil(int Cnt)
    {
        BallSet.inc.bgmCnt = Cnt;
        MapselectManager.instance.setMap(MapselectManager.MapState.DanMil);
    }
    public void select_GaUm(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GaUm); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_GeumSeong(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GeumSeong); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_GuChan(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GuChan); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_JeomGok(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.JeomGok); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_OkSan(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.OkSan); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_SaGak(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.SaGak); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_SinPyenog(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.SinPyenog); BallSet.inc.bgmCnt = Cnt;
    }
    public void select_UiSeong(int Cnt)
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.UiSeong); 
        BallSet.inc.bgmCnt = Cnt;
    }
}
