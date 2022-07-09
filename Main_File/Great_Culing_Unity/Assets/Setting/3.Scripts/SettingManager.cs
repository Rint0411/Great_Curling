using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    [Header("종료패널")]
    public GameObject ExitPanel;

    [Header("사운드바")]
    public AudioMixer masterMixer;
    public Slider audioSlider;

    void Update() {
      if(Input.GetKeyDown(KeyCode.Escape)) {
          Time.timeScale=0f;
      }  
    }

    public void PanelLoad() {
    ExitPanel.SetActive(true);
    }

    public void ExitYes() {
        Application.Quit();
    }

    public void ExitNo() {
        Time.timeScale = 1f;
        ExitPanel.SetActive(false);
    }

    public void AudioControlBGM() {
        float sound = audioSlider.value;
        if(sound == -40f) {
            masterMixer.SetFloat("BGM", -80f);
        }else {
            masterMixer.SetFloat("BGM", sound);
        }
    }

    public void AudioControlSFX() {
        float sound = audioSlider.value;
        if(sound == -40f) {
            masterMixer.SetFloat("SFX", -80f);
        }else {
            masterMixer.SetFloat("SFX", sound);
        }
    }

    public void AudioVolume() {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}
