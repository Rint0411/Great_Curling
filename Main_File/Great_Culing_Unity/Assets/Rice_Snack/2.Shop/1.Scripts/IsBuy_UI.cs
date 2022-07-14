using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsBuy_UI : MonoBehaviour
{
    [SerializeField] GameObject GameManager;
    [SerializeField] GameObject ItemId;
    [SerializeField] GameObject BuyFrame;
    [SerializeField] Text text;
    void Update()
    {
        if (GameManager.GetComponent<Gamemanager>().IsBuy[ItemId.GetComponent<Item_Price>().Item_Id])
        {
            text.text = "구매됨";
            BuyFrame.SetActive(true);
        }
    }
}
