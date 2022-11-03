using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoSom : MonoBehaviour
{
    public static EfeitoSom Instance;

    public AudioSource fogos;
    public AudioSource acerto;
    public AudioSource pena;
    public AudioSource musicaTema;
    public AudioSource batimento;
    public AudioSource pulo;
    public AudioSource magia;
    public AudioSource trofeu;
    void Awake()
    {
        Instance = this;
    }
}
