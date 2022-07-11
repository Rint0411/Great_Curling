using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random_Color : MonoBehaviour
{
        int col;
        int count = 1;

    [Header("게임 오브젝트")]
    public GameObject Button,blue,red, Main;

    public GameObject ColorBox;
    public GameObject BackGround;

    public GameObject RedText;
    public GameObject BlueText;

    public GameObject RedScreen;
    public GameObject BlueScreen;
    
    private Image colorbox;
    private Image background;
    
    void Start() {
        colorbox = ColorBox.GetComponent<Image>();
        background = BackGround.GetComponent<Image>();
    }

    IEnumerator Ready() {
        while(count <= 5) {
         if(count%2==1) {
        RedScreen.SetActive(true);
        BlueScreen.SetActive(false);
         }else {
        BlueScreen.SetActive(true);
         RedScreen.SetActive(false);
         }
         count++;
            SoundMng.instance.PlaySe(3);
            yield return new WaitForSeconds(0.4f);
        }
        ColorRedBlue();
    }

    public void Anim() {
        StartCoroutine(Ready());
        Destroy(Button);
    }

    void ColorRedBlue() 
    {
        col = Random.Range(0,2);

        if(0 == col) {
            RedScreen.SetActive(true);
            BlueScreen.SetActive(false);
            RedText.gameObject.SetActive(true);
            BlueText.gameObject.SetActive(false);
            background.color = new Color32(255,120,120,255);
        }else {
            BlueScreen.SetActive(true);
            RedScreen.SetActive(false);
            RedText.gameObject.SetActive(false);
            BlueText.gameObject.SetActive(true);
            background.color = new Color32(120,120,255,255);
        }
        SoundMng.instance.PlaySe(4);
        Invoke("Next", 1);
    }
    
    void Next()
    {
        if(col != 0)
        {
            VariableMng.VRBMNG.RedandBlueTurn = true;
            Instantiate(blue);
        }else 
        {
            VariableMng.VRBMNG.RedandBlueTurn = false;
             Instantiate(red);
        }
        Destroy(Main);
    }

}
