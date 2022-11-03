using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trofeus : MonoBehaviour
{
    public GameObject bronze;
    public GameObject prata;
    public GameObject ouro;
    public static bool salaTrofeu;
    public static bool salaTrofeu2;
    public static bool salaTrofeu3;
    public int trofeuT;


    void Start()
    {


        if (PlayerPrefs.HasKey("LocalTrofeu2") && PlayerPrefs.GetInt("TrofeuA") == 1)
        {
            trofeuT = PlayerPrefs.GetInt("LocalTrofeu2");

        }

    }
        void Update()
    {
       if(salaTrofeu)
        {
            if(trofeuT < 30)
            {
                trofeuT = 30;
                PlayerPrefs.SetInt("LocalTrofeu2", trofeuT);
                PlayerPrefs.SetInt("TrofeuA", 1);
            }
        }

        if (salaTrofeu2)
        {
            if (trofeuT < 60)
            {
                trofeuT = 60;
                PlayerPrefs.SetInt("LocalTrofeu2", trofeuT);
                PlayerPrefs.SetInt("TrofeuA", 1);
            }
        }
        if (salaTrofeu3)
        {
            if (trofeuT < 100)
            {
                trofeuT = 100;
                PlayerPrefs.SetInt("LocalTrofeu2", trofeuT);
                PlayerPrefs.SetInt("TrofeuA", 1);
            }
        }
 
 //-----------------------------------------------------------


        if (trofeuT >= 30)
        {
            bronze.SetActive(true);
        }

        if (trofeuT >= 60)
        {
            prata.SetActive(true);
        }
        if (trofeuT >= 100)
        {
            ouro.SetActive(true);
        }
    }
}
