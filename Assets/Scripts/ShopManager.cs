using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    //items available
    public int[,] shopItems = new int[3,20];

    int bank;
    public Text CoinsTxt;

    RawImage[] gemIcon;


    void Start()
    {
        CoinsTxt.text = PlayerPrefs.GetInt("bank").ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;
        shopItems[1, 13] = 13;
        shopItems[1, 14] = 14;
        shopItems[1, 15] = 15;
        shopItems[1, 16] = 16;
        shopItems[1, 17] = 17;
        shopItems[1, 18] = 18;

        //Price
        shopItems[2, 1] = 18;
        shopItems[2, 2] = 14;
        shopItems[2, 3] = 21;
        shopItems[2, 4] = 22;
        shopItems[2, 5] = 28;
        shopItems[2, 6] = 26;
        shopItems[2, 7] = 16;
        shopItems[2, 8] = 12;
        shopItems[2, 9] = 12;
        shopItems[2, 10] = 16;
        shopItems[2, 11] = 22;
        shopItems[2, 12] = 14;
        shopItems[2, 13] = 10;
        shopItems[2, 14] = 14;
        shopItems[2, 15] = 15;
        shopItems[2, 16] = 22;
        shopItems[2, 17] = 11;
        shopItems[2, 18] = 19;


    }

   
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        int itemId = ButtonRef.GetComponent<ButtonInfo>().ItemID;

        if (PlayerPrefs.GetInt("bank") >= shopItems[2, itemId] & ButtonRef.GetComponent<ButtonInfo>().isBoughtPrefs[itemId] == 0)

        //if (PlayerPrefs.GetInt("bank") >= shopItems[2, itemId] & ButtonRef.GetComponent<ButtonInfo>().isBoughtPrefs[ButtonRef.GetComponent<ButtonInfo>().ItemID] == 0)
        {
            //ButtonRef.GetComponent<ButtonInfo>().isBought = true;

            bank = PlayerPrefs.GetInt("bank");
            bank -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            PlayerPrefs.SetInt("bank", bank);
            CoinsTxt.text = PlayerPrefs.GetInt("bank").ToString();
            ButtonRef.GetComponent<ButtonInfo>().GetComponent<Image>().enabled = false;


            switch (ButtonRef.GetComponent<ButtonInfo>().ItemID)
            {
                case 1:
                    PlayerPrefs.SetInt("isBought0", 1);
                    break;
                case 2:
                    PlayerPrefs.SetInt("isBought1", 1);
                    break;
                case 3:
                    PlayerPrefs.SetInt("isBought2", 1);
                    break;
                case 4:
                    PlayerPrefs.SetInt("isBought3", 1);
                    break;
                case 5:
                    PlayerPrefs.SetInt("isBought4", 1);
                    break;
                case 6:
                    PlayerPrefs.SetInt("isBought5", 1);
                    break;
                case 7:
                    PlayerPrefs.SetInt("isBought6", 1);
                    break;
                case 8:
                    PlayerPrefs.SetInt("isBought7", 1);
                    break;
                case 9:
                    PlayerPrefs.SetInt("isBought8", 1);
                    break;
                case 10:
                    PlayerPrefs.SetInt("isBought9", 1);
                    break;
                case 11:
                    PlayerPrefs.SetInt("isBought10", 1);
                    break;
                case 12:
                    PlayerPrefs.SetInt("isBought11", 1);
                    break;
                case 13:
                    PlayerPrefs.SetInt("isBought12", 1);
                    break;
                case 14:
                    PlayerPrefs.SetInt("isBought13", 1);
                    break;
                case 15:
                    PlayerPrefs.SetInt("isBought14", 1);
                    break;
                case 16:
                    PlayerPrefs.SetInt("isBought15", 1);
                    break;
                case 17:
                    PlayerPrefs.SetInt("isBought16", 1);
                    break;
                case 18:
                    PlayerPrefs.SetInt("isBought17", 1);
                    break;
            }



            //set material to the ball
            setMaterial(ButtonRef.GetComponent<ButtonInfo>().ItemID);

            FindObjectOfType<AudioManager>().Play("Shop");

        }

        else 
        {
            //set material to the ball
            setMaterial(ButtonRef.GetComponent<ButtonInfo>().ItemID);
        }

        if(ButtonRef.GetComponent<ButtonInfo>().isBoughtPrefs[itemId] == 1)
        {
            FindObjectOfType<AudioManager>().Play("Selected");
        }

    }

    public void setMaterial(int choice)
    {
        switch (choice)
        {
            case 1:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 2:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 3:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 4:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 5:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 6:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 7:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 8:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 9:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 10:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 11:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 12:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 13:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 14:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 15:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 16:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 17:
                PlayerPrefs.SetInt("material", choice);
                break;
            case 18:
                PlayerPrefs.SetInt("material", choice);
                break;
        }
    }
}
