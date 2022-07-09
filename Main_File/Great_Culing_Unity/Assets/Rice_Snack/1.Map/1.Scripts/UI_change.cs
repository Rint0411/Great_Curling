using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_change : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Text text_name;
    [SerializeField] Text text_explin;
    private void Update()
    {
        text_name.text = MapselectManager.instance._name;
        text_explin.text = MapselectManager.instance._expline;
    }
}
