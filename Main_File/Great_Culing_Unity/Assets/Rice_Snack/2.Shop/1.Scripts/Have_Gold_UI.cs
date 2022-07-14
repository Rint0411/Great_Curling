using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Have_Gold_UI : MonoBehaviour
{
    [SerializeField] Text text;
    private void Update()
    {
        text.text = Gamemanager.Gold.ToString();
    }
}
