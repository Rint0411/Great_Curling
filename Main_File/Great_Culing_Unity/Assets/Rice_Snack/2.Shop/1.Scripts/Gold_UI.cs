using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gold_UI : MonoBehaviour
{
    [SerializeField] GameObject ItemPrice;
    private void Start()
    {
        this.gameObject.GetComponent<Text>().text = ItemPrice.GetComponent<Item_Price>().Item_price.ToString();
    }
}
