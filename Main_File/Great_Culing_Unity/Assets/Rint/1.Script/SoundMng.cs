using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMng : MonoBehaviour
{
    public static SoundMng instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //bgmAudioSource.volume = PlayerPrefs.GetFloat("BGM");
        //SeAudioSource.volume = PlayerPrefs.GetFloat("SE");
    }
    public float effectValue, bgmValue;
    [SerializeField] private AudioSource bgmAudioSource, SeAudioSource;
    [Space(25)]
    [SerializeField] private BgmClip[] BGMSoundSet;
    [SerializeField] private SeClip[] EffectSoundSet;


    public void PlayBgm(int count)
    {
        bgmAudioSource.clip = BGMSoundSet[count].clip;
        bgmAudioSource.Play();
    }
    public void PlaySe(int count)
    {
        SeAudioSource.PlayOneShot(EffectSoundSet[count].clip);
    }
    private bool muteCheck = false;

    public void Mute()
    {
        if (muteCheck == false)
        {
            bgmAudioSource.Stop();
            muteCheck = true;
        }
        else
        {
            bgmAudioSource.Play();
            muteCheck = false;
        }

    }
    public void SetBgm(float sound)
    {
        bgmAudioSource.volume = sound;
        bgmAudioSource.PlayOneShot(EffectSoundSet[1].clip);
        PlayerPrefs.SetFloat("BGM", sound);
    }
    public void SetEffect(float sound)
    {
        SeAudioSource.volume = sound;
        SeAudioSource.PlayOneShot(EffectSoundSet[1].clip);
        PlayerPrefs.SetFloat("SE", sound);
    }

}
[System.Serializable]
class BgmClip
{
    [SerializeField] private string name;
    [SerializeField] public AudioClip clip;
}
[System.Serializable]
class SeClip
{
    [SerializeField] private string name;
    [SerializeField] public AudioClip clip;
}
