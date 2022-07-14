using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsBuy_UI : MonoBehaviour
{

    [SerializeField] Item_Price ItemId;
    [SerializeField] GameObject BuyFrame;
    [SerializeField] Text text;
    void Update()
    {
        if (Gamemanager.IsBuy[ItemId.Item_Id])
        {
            text.text = "구매됨";
            BuyFrame.SetActive(true);
        }
    }
}
