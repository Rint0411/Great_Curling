using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] Item_Price Item_price;
    [SerializeField] GameObject NoGoldFrame;
    public void Buy_Item()
    {
        if(!Gamemanager.IsBuy[Item_price.Item_Id]){
            if (Gamemanager.Gold < Item_price.Item_price)
            {
                NoGoldFrame.SetActive(true);
            }
            else
            {
                Gamemanager.Gold -= Item_price.Item_price;
                Gamemanager.IsBuy[Item_price.Item_Id] = true;
                PlayerPrefs.SetInt("IsBuy"+Item_price.Item_Id, 1);
            }
        }
    }
}
