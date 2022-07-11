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
        SoundMng.instance.PlayBgm(2);
        SoundMng.instance.PlaySe(2);
    }
    public void select_AnGae()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.AnGae);
    }
    public void select_Anpyeong()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.Anpyeong);
    }
    public void select_AnSa()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.AnSa);
    }
    public void select_BiAn()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.BiAn);
    }
    public void select_BongYang()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.BongYang);
    }
    public void select_ChonSan()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.ChonSan);
    }
    public void select_DaIn()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DaIn);
    }
    public void select_DanBuk()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DanBuk);
    }
    public void select_DanChon()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DanChon);
    }
    public void select_DanMil()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.DanMil);
    }
    public void select_GaUm()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GaUm);
    }
    public void select_GeumSeong()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GeumSeong);
    }
    public void select_GuChan()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.GuChan);
    }
    public void select_JeomGok()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.JeomGok);
    }
    public void select_OkSan()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.OkSan);
    }
    public void select_SaGak()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.SaGak);
    }
    public void select_SinPyenog()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.SinPyenog);
    }
    public void select_UiSeong()
    {
        MapselectManager.instance.setMap(MapselectManager.MapState.UiSeong);
    }
}
