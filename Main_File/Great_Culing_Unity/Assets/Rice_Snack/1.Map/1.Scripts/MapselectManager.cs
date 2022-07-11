using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapselectManager : MonoBehaviour
{
    public static MapselectManager instance = null;
    private void Awake()
    {
        if(null == instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        SoundMng.instance.PlayBgm(1);
    }
    public List<Sprite> images;
    [TextArea]
    public List<string> names;
    [TextArea]
    public List<string> expline;
    public enum MapState{AnGae, Anpyeong, AnSa, BiAn, BongYang, ChonSan, DaIn, DanBuk, DanChon, DanMil, GaUm, GeumSeong, GuChan, JeomGok, OkSan, SaGak, SinPyenog, UiSeong};
    public Sprite _sprite;
    public string _name;
    public string _expline;
    public MapState NowState;
    public GameObject[] mapbig;
    public GameObject[] Maps;

    public void setMap(MapState state)
    {
        NowState = state;
        _sprite = images[(int)state];
        _name = names[(int)state];
        _expline = expline[(int)state];
    }
}
