using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterial : MonoBehaviour
{
    public Material[] materials;
    int materialPref;
    // Start is called before the first frame update
    void Start()
    {
        switch (PlayerPrefs.GetInt("material", 14))
        {
            case 1:
                gameObject.GetComponent<Renderer>().material = materials[0];
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material = materials[1];
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material = materials[2];
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material = materials[3];
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material = materials[4];
                break;
            case 6:
                gameObject.GetComponent<Renderer>().material = materials[5];
                break;
            case 7:
                gameObject.GetComponent<Renderer>().material = materials[6];
                break;
            case 8:
                gameObject.GetComponent<Renderer>().material = materials[7];
                break;
            case 9:
                gameObject.GetComponent<Renderer>().material = materials[8];
                break;
            case 10:
                gameObject.GetComponent<Renderer>().material = materials[9];
                break;
            case 11:
                gameObject.GetComponent<Renderer>().material = materials[10];
                break;
            case 12:
                gameObject.GetComponent<Renderer>().material = materials[11];
                break;
            case 13:
                gameObject.GetComponent<Renderer>().material = materials[12];
                break;
            case 14:
                gameObject.GetComponent<Renderer>().material = materials[13];
                break;
            case 15:
                gameObject.GetComponent<Renderer>().material = materials[14];
                break;
            case 16:
                gameObject.GetComponent<Renderer>().material = materials[15];
                break;
            case 17:
                gameObject.GetComponent<Renderer>().material = materials[16];
                break;
            case 18:
                gameObject.GetComponent<Renderer>().material = materials[17];
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
