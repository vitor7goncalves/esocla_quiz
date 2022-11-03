using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public float tutorial;
    public Text tutoTexto;

    public GameObject grande;
    public GameObject medio;
    public GameObject pequeno;
    public GameObject coracao;
    public GameObject pulo;
    public GameObject torneio;
    public GameObject dificil;
    public GameObject facil;
    public GameObject proximo;
    public GameObject voltar;

    
    void Update()
    {
        if (tutorial == 0)
        {
            tutoTexto.text = ("Olá! Bem vindo ao Magus Pocus Quiz.");
            voltar.SetActive(false);
        }
        else
        {
            voltar.SetActive(true);
        }

        if (tutorial == 1)
        {
            tutoTexto.text = ("Neste tutorial vou lhe dar uma rápida explicação sobre a mecânica do jogo.");
        }

        if (tutorial == 2)
        {
            tutoTexto.text = ("Farei perguntas para testar seus conhecimentos, e você terá 30 segundos para responde-las.");
        }

        if (tutorial == 3)
        {
            tutoTexto.text = ("Se voce errar ou não responder a tempo, perderá uma vida. São esses corações aqui");
            coracao.SetActive(true);
        }
        else
        {
            coracao.SetActive(false);
        }

        if (tutorial == 4)
        {
            tutoTexto.text = ("Mas se achar a pergunta muito difícil, você poderá usar o pulo. Tenha em mente que você só terá direito a pular uma vez!");
            pulo.SetActive(true);
        }
        else
        {
            pulo.SetActive(false);
        }

        if (tutorial == 5)
        {
            tutoTexto.text = ("Além do pulo você terá essas três gemas mágicas para ajudar. A grande elimina 3 respostas erradas, a média 2 e a pequena 1.");
            grande.SetActive(true);
            medio.SetActive(true);
            pequeno.SetActive(true);
        }
        else
        {
            grande.SetActive(false);
            medio.SetActive(false);
            pequeno.SetActive(false);
        }

        if (tutorial == 6)
        {
            tutoTexto.text = ("Para cada resposta correta você receberá pontos afim de acumular a maior pontuação possível.");
        }

        if (tutorial == 7)
        {
            tutoTexto.text = ("Para finalizar. Escolha uma modalidade e DIVIRTA-SE!");

            torneio.SetActive(true);
            dificil.SetActive(true);

            proximo.SetActive(false);
        }
        else
        {
            torneio.SetActive(false);
            dificil.SetActive(false);
            
            proximo.SetActive(true);
        }

        if (tutorial < 0)
        {
            tutorial = 0;
        }

        if (tutorial > 7)
        {
            tutorial = 7;
        }
    }

    public void tutorialMais()
    {
        tutorial++;
    }

    public void tutorialMenos()
    {
        tutorial--;
    }
    public void X()
    {
        tutorial = 7;
    }
}
