﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int ItemID;
    public Text PriceTxt;
    public GameObject ShopManager;
    public bool isBought = false;

    int price;

    public int[] isBoughtPrefs= new int[20];

    private void Start()
    {

        
    }
    void Update()
    {
        for (int i = 1; i <= 18; i++)
        {
            switch (i)
            {
                case 1:
                    isBoughtPrefs[i] = 1;
                    break;
                case 2:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought1", 0);
                    break;
                case 3:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought2", 0);
                    break;
                case 4:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought3", 0);
                    break;
                case 5:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought4", 0);
                    break;
                case 6:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought5", 0);
                    break;
                case 7:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought6", 0);
                    break;
                case 8:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought7", 0);
                    break;
                case 9:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought8", 0);
                    break;
                case 10:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought9", 0);
                    break;
                case 11:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought10", 0);
                    break;
                case 12:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought11", 0);
                    break;
                case 13:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought12", 0);
                    break;
                case 14:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought13", 0);
                    break;
                case 15:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought14", 0);
                    break;
                case 16:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought15", 0);
                    break;
                case 17:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought16", 0);
                    break;
                case 18:
                    isBoughtPrefs[i] = PlayerPrefs.GetInt("isBought17", 0);
                    break;
            }
        }

        if (isBoughtPrefs[ItemID]==0)
        {


            PriceTxt.text = ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();

            //converting score to integer
            int.TryParse(PriceTxt.text, out price);

            if (PlayerPrefs.GetInt("bank") >= price)
            //SET IMAGE GREEN
            {
                GetComponent<Image>().color = new Color32(103, 255, 0, 61);
            }
            else
            //SET IMAGE RED
            {

                gameObject.GetComponent<Button>().interactable = false;
                GetComponent<Image>().color = new Color32(186, 29, 0, 99);
            }

            //SHOWING PRICE

            PriceTxt.GetComponent<Text>().enabled = true;

            //SHOWING LOGO
            foreach (RawImage logo in GetComponentsInChildren<RawImage>())
            {
                if (logo.tag == "Gem")
                    logo.enabled = true;
            }
        }
        else
        {
            foreach (RawImage logo in GetComponentsInChildren<RawImage>())
            {
                if (logo.tag == "Gem")
                    logo.enabled = false;
            }
            PriceTxt.GetComponent<Text>().enabled = false;

        }


    }
}
