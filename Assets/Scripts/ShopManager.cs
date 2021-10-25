using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    //items available
    public int[,] shopItems = new int[5,5];

    int bank;
    public Text CoinsTxt;


    void Start()
    {
        CoinsTxt.text = PlayerPrefs.GetInt("bank").ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 1;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;

    }

   
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PlayerPrefs.GetInt("bank") >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID] & !ButtonRef.GetComponent<ButtonInfo>().isBought)
        {
            ButtonRef.GetComponent<ButtonInfo>().isBought = true;
            bank = PlayerPrefs.GetInt("bank");
            bank -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            PlayerPrefs.SetInt("bank", bank);
            //shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTxt.text = PlayerPrefs.GetInt("bank").ToString();
            //ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
            ButtonRef.GetComponent<ButtonInfo>().GetComponent<Image>().enabled = false;
            ButtonRef.GetComponent<ButtonInfo>().GetComponentInChildren<RawImage>().enabled = false;
            

        }


    }
}
