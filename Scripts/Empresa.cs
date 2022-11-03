using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Empresa : MonoBehaviour
{
    
    void Start()
    {
        Invoke("Tempo", 7f);
    }

    void Tempo()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
