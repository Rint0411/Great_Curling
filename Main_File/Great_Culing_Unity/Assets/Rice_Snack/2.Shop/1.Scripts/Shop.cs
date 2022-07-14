using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject Item_price;
    [SerializeField] GameObject NoGoldFrame;
    [SerializeField] GameObject GameManager;
    public void Buy_Item()
    {
        if(!GameManager.GetComponent<Gamemanager>().IsBuy[Item_price.GetComponent<Item_Price>().Item_Id]){
            if (Gamemanager.Gold < Item_price.GetComponent<Item_Price>().Item_price)
            {
                NoGoldFrame.SetActive(true);
            }
            else
            {
                Gamemanager.Gold -= Item_price.GetComponent<Item_Price>().Item_price;
                GameManager.GetComponent<Gamemanager>().IsBuy[Item_price.GetComponent<Item_Price>().Item_Id] = true;
            }
        }
    }
}
