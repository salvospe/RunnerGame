using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject ShopManager;
    public bool isBought = false;

    void Update()
    {
        if (!isBought)
            PriceTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        else
            PriceTxt.GetComponent<Text>().enabled = false;
    }
}
