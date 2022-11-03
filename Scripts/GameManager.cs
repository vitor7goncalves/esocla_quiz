using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public string respostaCorreta;
    public string perguntaAle;
    public string respostaAleA;
    public string respostaAleB;
    public string respostaAleC;
    public string respostaAleD;

    public List<string> perguntas = new List<string>();
    public List<string> alternativaA = new List<string>();
    public List<string> alternativaB = new List<string>();
    public List<string> alternativaC = new List<string>();
    public List<string> alternativaD = new List<string>();
    public List<string> corretas = new List<string>();

    private int idPergunta;

    private float questoes;

    int fim;

    public Text tempoText;
    public float tempo;
    float tempoCongela;
    float vida;
    public GameObject venceu;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    public GameObject fimJogo;
    public GameObject botaoA;
    public GameObject botaoB;
    public GameObject botaoC;
    public GameObject botaoD;
    public GameObject botaoPulo;
    public GameObject puloEfeito;
    public Text pontuacao;
    public float pontos;
    public Text ponto500;
    public Text respCorreto;

    public GameObject correto;
    public GameObject errado;
    public GameObject estrela;
    public GameObject estrela2;
    public GameObject estrela3;
    bool tempoBat;

    public int maximoPerguntas;
    public int minimo;
    public int maximo;
    int vitoria;

    public List<int> perguntasFeitas = new List<int>();
    
    public int trofeu;
    public GameObject trofeuBronze;
    public GameObject trofeuPrata;
    public GameObject trofeuOuro;
    public GameObject brilho;
    
    public GameObject balao;

    public GameObject notaMusical;
    public GameObject notaMusicalDesativado;
    public GameObject som;

    void Start()
    {
        minimo = 1;
        maximo = 70;
        vitoria = 69;

        if (PlayerPrefs.HasKey("LocalTrofeu") && PlayerPrefs.GetInt("TrofeuV") == 1)
        {
            trofeu = PlayerPrefs.GetInt("LocalTrofeu");
            
        }
        
        InicioPergunta();

            pergunta.text = perguntaAle.ToString();
            respostaA.text = respostaAleA.ToString();
            respostaB.text = respostaAleB.ToString();
            respostaC.text = respostaAleC.ToString();
            respostaD.text = respostaAleD.ToString();

            pontuacao.text = pontos.ToString();

            perguntas.Add(perguntaAle);
            alternativaA.Add(respostaAleA);
            alternativaB.Add(respostaAleB);
            alternativaC.Add(respostaAleC);
            alternativaD.Add(respostaAleD);
            corretas.Add(respostaCorreta);

            fim = 0;

            tempo = 30;

            tempoText.text = tempo.ToString();


            fimJogo.SetActive(false);

            vida = 3;

            vida1.SetActive(true);
            vida2.SetActive(true);
            vida3.SetActive(true);

            botaoA.SetActive(true);
            botaoB.SetActive(true);
            botaoC.SetActive(true);
            botaoD.SetActive(true);

            tempoCongela = 0;
            venceu.SetActive(false);
            puloEfeito.SetActive(false);
            ponto500.text = null;

            errado.SetActive(false);
            correto.SetActive(false);
            estrela.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
    }

    public int InicioPergunta()
    {
            maximoPerguntas = Random.Range(minimo, maximo);

            if (maximoPerguntas == 1)
            {
                perguntaAle = ("Quanto é 1 + 1?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("2");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("3");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("5");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("8");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("2");
            }
            else if (maximoPerguntas == 2)
            {
                perguntaAle = ("Quem descobriu o Brasil?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Dom João VI");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Alexandre o Grande");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Dom Pedro I");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Pedro Alvarez Cabral");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Pedro Alvarez Cabral");
            }
            else if (maximoPerguntas == 3)
            {
                perguntaAle = ("Qual desses números é maior que 10?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("9");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("8");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("11");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("5");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("11");
            }
            else if (maximoPerguntas == 4)
            {
                perguntaAle = ("Qual desses físicos criou a teoria geral de relatividade?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Isaac Newton");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Galileo Galilei");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Wilhelm Röntgen");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Albert Einstein");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Albert Einstein");

            }
            else if (maximoPerguntas == 5)
            {
                perguntaAle = ("De quem é a famosa frase “Penso, logo existo”?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Platão");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Galileu Galilei");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Descartes");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Sócrates");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Descartes");
            }
            else if (maximoPerguntas == 6)
            {
                perguntaAle = ("De onde é a invenção do chuveiro elétrico?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("França");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Inglaterra");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Brasil");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Austrália");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Brasil");
            }
            else if (maximoPerguntas == 7)
            {
                perguntaAle = ("Qual o nome do presidente do Brasil que ficou conhecido como Jango?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("João Goulart");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Jacinto Anjos");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Getúlio Vargas");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("João Figueiredo");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("João Goulart");
            }
            else if (maximoPerguntas == 8)
            {
                perguntaAle = ("Qual o grupo em que todas as palavras foram escritas corretamente?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Asterístico, beneficiente, meteorologia");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Asterisco, beneficinte, meteorologia");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Asterisco, beneficente, metereologia");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Asterisco, beneficente, meteorologia");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Asterisco, beneficente, meteorologia");
            }
            else if (maximoPerguntas == 9)
            {
                perguntaAle = ("Qual o livro mais vendido no mundo a seguir à Bíblia?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("O Senhor dos Anéis");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Dom Quixote");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("O Pequeno Príncipe");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Ela, a Feiticeira");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Dom Quixote");
            }
            else if (maximoPerguntas == 10)
            {
                perguntaAle = ("Quantas casas decimais tem o número pi?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Duas");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Centenas");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Trilhares");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Vinte");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Trilhares");
            }
            else if (maximoPerguntas == 11)
            {
                perguntaAle = ("Atualmente, quantos elementos químicos a tabela periódica possui?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("113");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("109");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("108");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("118");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("118");
            }
            else if (maximoPerguntas == 12)
            {
                perguntaAle = ("Quais os países que têm a maior e a menor expectativa de vida do mundo?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Japão e Serra Leoa");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Austrália e Afeganistão");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Itália e Chade");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Brasil e Congo");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Japão e Serra Leoa");
            }
            else if (maximoPerguntas == 13)
            {
                perguntaAle = ("O que a palavra legend significa em português?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Legenda");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Conto");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("História");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Lenda");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Lenda");

            }
        else if (maximoPerguntas == 14)
        {
            perguntaAle = ("Quais o menor e o maior país do mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Vaticano e Rússia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Nauru e China");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Mônaco e Canadá");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Malta e Estados Unidos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Vaticano e Rússia");
        }
        else if (maximoPerguntas == 15)
        {
            perguntaAle = ("Qual o número mínimo de jogadores numa partida de futebol?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("10");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("9");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("5");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("7");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("7");
        }
        else if (maximoPerguntas == 16)
        {
            perguntaAle = ("Quais os principais autores do Barroco no Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Gregório de Matos, Bento Teixeira e Manuel Botelho de Oliveira");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Miguel de Cervantes, Gregório de Matos e Danthe Alighieri");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Castro Alves, Bento Teixeira e Manuel Botelho de Oliveira");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Álvares de Azevedo, Gregório de Matos e Bento Teixeira");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Gregório de Matos, Bento Teixeira e Manuel Botelho de Oliveira");
        }
        else if (maximoPerguntas == 17)
        {
            perguntaAle = ("Quais as duas datas que são comemoradas em novembro?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Independência do Brasil e Dia da Bandeira");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Proclamação da República e Dia Nacional da Consciência Negra");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Dia do Médico e Dia de São Lucas");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dia de Finados e Dia Nacional do Livro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Proclamação da República e Dia Nacional da Consciência Negra");
        }
        else if (maximoPerguntas == 18)
        {
            perguntaAle = ("Quem pintou Guernica?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Paul Cézanne");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Pablo Picasso");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Diego Rivera");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Salvador Dalí");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Pablo Picasso");
        }
        else if (maximoPerguntas == 19)
        {
            perguntaAle = ("Quanto tempo a luz do Sol demora para chegar à Terra?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("12 minutos");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1 dia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("8 minutos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("segundos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("8 minutos");
        }
        else if (maximoPerguntas == 20)
        {
            perguntaAle = ("Qual a tradução da frase “Fabiano cogió su saco antes de salir”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Fabiano coseu seu paletó antes de sair");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Fabiano fechou o saco antes de sair");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Fabiano pegou seu paletó antes de sair");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Fabiano cortou o saco antes de cair");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Fabiano pegou seu paletó antes de sair");
        }
        else if (maximoPerguntas == 21)
        {
            perguntaAle = ("Qual a altura da rede de vôlei nos jogos masculino e feminino?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("2,5 m e 2,0 m");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1,8 m e 1,5 m");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("2,45 m e 2,15 m");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("2,43 m e 2,24 m");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("2,43 m e 2,24 m");
        }
        else if (maximoPerguntas == 22)
        {
            perguntaAle = ("Qual o nome do tratado comercial entre os países da América Latina?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Tratado de Tordesilhas");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Mercosul");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("EuroÁsia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Hermanos Econômicos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Mercosul");
        }
        else if (maximoPerguntas == 23)
        {
            perguntaAle = ("Em quantas camadas se divide uma célula?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("2");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("4");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("3");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("5");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("3");
        }
        else if (maximoPerguntas == 24)
        {
            perguntaAle = ("Qual cidade foi capital do Brasil entre 1763 e 1961?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Salvador");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Brasília");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Tocantins");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Rio de janeiro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Rio de janeiro");
        }
        else if (maximoPerguntas == 25)
        {
            perguntaAle = ("A teoria do ''Salto Quântico'' explica o comportamento peculiar dos elétrons saltando entre as camadas de um átomo.De qual campo científico pertenceessa teoria ? ");
       
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Matemática");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Química");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Física");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Paleontologia");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Física");
        }
        else if (maximoPerguntas == 26)
        {
            perguntaAle = ("Qual o maior satélite natural de Júpiter");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Terra");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Lua");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Ganímedes");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Órion");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Ganímedes");
        }
        else if (maximoPerguntas == 27)
        {
            perguntaAle = ("Qual satélite de Jupiter é coberto por gelo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Europa");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Ganímedes");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Io");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Calisto");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Europa");
        }
        else if (maximoPerguntas == 28)
        {
            perguntaAle = ("Em que ordem surgiram os modelos atômicos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Thomson, Dalton, Rutherford, Rutherford-Bohr");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rutherford-Bohr, Rutherford, Thomson, Dalton");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Dalton, Thomson, Rutherford-Bohr, Rutherford");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dalton, Thomson, Rutherford, Rutherford-Bohr");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Dalton, Thomson, Rutherford, Rutherford-Bohr");
        }
        else if (maximoPerguntas == 29)
        {
            perguntaAle = ("Em que período da pré-história o fogo foi descoberto?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Neolítico");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Paleolítico");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Idade dos Metais");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Período da Pedra Polida");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Paleolítico");
        }
        else if (maximoPerguntas == 30)
        {
            perguntaAle = ("Qual das alternativas abaixo apenas contêm classes de palavras?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Vogais, semivogais e consoantes");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Artigo, verbo transitivo e verbo intransitivo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Hiatos, ditongos e tritongos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Substantivo, verbo e preposição");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Substantivo, verbo e preposição");
        }
        else if (maximoPerguntas == 31)
        {
            perguntaAle = ("Qual a montanha mais alta do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Pico da Neblina");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Pico Paraná");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Monte Roraima");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Pico Maior de Friburgo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Pico da Neblina");
        }
        else if (maximoPerguntas == 32)
        {
            perguntaAle = ("Qual a velocidade da luz?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("300 000 000 metros por segundo (m/s)");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("150 000 000 metros por segundo (m/s)");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("199 792 458 metros por segundo (m/s)");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("299 792 458 metros por segundo (m/s)");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("299 792 458 metros por segundo (m/s)");
        }
        else if (maximoPerguntas == 33)
        {
            perguntaAle = ("Em qual local da Ásia o português é a língua oficial?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Índia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Filipinas");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Macau");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Portugal");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Macau");
        }
        else if (maximoPerguntas == 34)
        {
            perguntaAle = ("“It is six twenty ou twenty past six”. Que horas são em inglês?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("12:06");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("6:20");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("2:20");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("6:02");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("6:20");
        }
        else if (maximoPerguntas == 35)
        {
            perguntaAle = ("Quem é o autor de “O Príncipe”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Maquiavel");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Antoine de Saint-Exupéry");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Montesquieu");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Thomas Hobbes");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Maquiavel");
        }
        else if (maximoPerguntas == 36)
        {
            perguntaAle = ("Quantos dias possui o ano bissexto?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("250");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("365");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("366");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("266");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("366");
        }
        else if (maximoPerguntas == 37)
        {
            perguntaAle = ("Atuamente qual a capital do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Brasília");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rio de Janeiro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("São Paulo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Salvador");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Brasília");
        }
        else if (maximoPerguntas == 38)
        {
            perguntaAle = ("Qual foi a primeira capital do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Salvador");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rio de Janeiro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Brasília");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Fortaleza");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Salvador");
        }
        else if (maximoPerguntas == 39)
        {
            perguntaAle = ("Quais são as cores primárias, também conhecidas como cores puras?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Azul, preto e branco");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Azul, vermelho e amarelo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Roxo, preto e rosa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Vermelho, amarelo e verde");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Azul, vermelho e amarelo");
        }
        else if (maximoPerguntas == 40)
        {
            perguntaAle = ("Quantas cores possui um arco-íris");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("5");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("8");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("7");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("4");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("7");
        }
        else if (maximoPerguntas == 41)
        {
            perguntaAle = ("Quais destas doenças são sexualmente transmissíveis?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Chikungunya, aids e herpes genital");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Aids, tricomoníase e ebola");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Gonorreia, clamídia e sífilis");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Hepatite B, febre tifoide e hanseníase");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Gonorreia, clamídia e sífilis");
        }
        else if (maximoPerguntas == 42)
        {
            perguntaAle = ("Como é a conjugação do verbo caber na 1.ª pessoa do singular do presente do indicativo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Eu caibo");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Ele cabe");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Que eu caiba");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Eu cabo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Eu caibo");
        }
        else if (maximoPerguntas == 43)
        {
            perguntaAle = ("Quais destas construções famosas ficam nos Estados Unidos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Estátua da Liberdade, Golden Gate Bridge e Empire State Building");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Estátua da Liberdade, Big Ben e The High Line");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Angkor Wat, Taj Mahal e Skywalk no Grand Canyon");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Lincoln Memorial, Sidney Opera House e Burj Khalifa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Estátua da Liberdade, Golden Gate Bridge e Empire State Building");
        }
        else if (maximoPerguntas == 44)
        {
            perguntaAle = ("Qual destes países é transcontinental?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Filipinas");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rússia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Tanzânia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Istambul");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Rússia");
        }
        else if (maximoPerguntas == 45)
        {
            perguntaAle = ("Em qual das orações abaixo a palavra foi empregada incorretamente?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Mais uma vez, portou-se mal");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("É um homem mal");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Esse é o mal de todos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("É um mau vendedor");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("É um homem mal");
        }
        else if (maximoPerguntas == 46)
        {
            perguntaAle = ("Qual foi o recurso utilizado inicialmente pelo homem para explicar a origem das coisas?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("A Filosofia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("A Biologia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("A Astronomia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("A Mitologia");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("A Mitologia");
        }
        else if (maximoPerguntas == 47)
        {
            perguntaAle = ("Quais os planetas do sistema solar?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Terra, Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Júpiter, Marte, Mercúrio, Netuno, Plutão, Saturno, Terra, Urano, Vênus");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Júpiter, Marte, Mercúrio, Netuno, Plutão, Saturno, Sol, Terra, Urano, Vênus");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Terra, Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
        }
        else if (maximoPerguntas == 48)
        {
            perguntaAle = ("Qual era o nome de Aleijadinho?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Alexandrino Francisco Lisboa");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Manuel Francisco Lisboa");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Antônio Francisco Lisboa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Francisco Antônio Lisboa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Antônio Francisco Lisboa");
        }
        else if (maximoPerguntas == 49)
        {
            perguntaAle = (" Júpiter e Plutão são os correlatos romanos de quais deuses gregos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Ares e Hermes");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Cronos e Apolo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Zeus e Hades");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dionísio e Deméter");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Zeus e Hades");
        }
        else if (maximoPerguntas == 50)
        {
            perguntaAle = ("Qual o maior animal terrestre?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Baleia Azul");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Dinossauro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Elefante africano");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Girafa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Elefante africano");
        }
        else if (maximoPerguntas == 51)
        {
            perguntaAle = ("Qual o tema do famoso discurso Eu Tenho um Sonho, de Martin Luther King?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Igualdade entre as etnias");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Justiça para os menos favorecidos");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Intolerância religiosa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Luta contra o Apartheid");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Igualdade entre as etnias");
        }
        else if (maximoPerguntas == 52)
        {
            perguntaAle = ("Que líder mundial ficou conhecida como “Dama de Ferro”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Dilma Rousseff");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Margaret Thatcher");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Hillary Clinton");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Christine Lagarde");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Margaret Thatcher");
        }
        else if (maximoPerguntas == 53)
        {
            perguntaAle = ("Quais os nomes dos três Reis Magos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Gaspar, Nicolau e Natanael");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Belchior, Gaspar e Baltazar");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Belchior, Gaspar e Nataniel");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Melchior, Noé e Galileu");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Belchior, Gaspar e Baltazar");
        }
        else if (maximoPerguntas == 54)
        {
            perguntaAle = ("Qual a religião monoteísta que conta com o maior número de adeptos no mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Judaísmo");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Zoroastrismo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Cristianismo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Islamismo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Cristianismo");
        }
        else if (maximoPerguntas == 55)
        {
            perguntaAle = ("Qual desses filmes foi baseado na obra de Shakespeare?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Muito Barulho por Nada (2012)");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Capitães de Areia (2011)");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("A Dama das Camélias (1936)");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Excalibur (1981)");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Muito Barulho por Nada (2012)");
        }
        else if (maximoPerguntas == 56)
        {
            perguntaAle = ("Quem foi o primeiro homem a pisar na Lua? Em que ano aconteceu?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Yuri Gagarin, em 1961");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Neils Armstrong, em 1969");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Buzz Aldrin, em 1969");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Charles Duke, em 1971");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Neils Armstrong, em 1969");
        }
        else if (maximoPerguntas == 57)
        {
            perguntaAle = ("Em qual data se comemora o Natal?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("23 de dezembro");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("24 de dezembro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("25 de novembro");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("25 de dezembro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("25 de dezembro");
        }
        else if (maximoPerguntas == 58)
        {
            perguntaAle = ("Qual o nome do cientista que descobriu o processo de pasteurização e a vacina contra a raiva?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Marie Curie");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Blaise Pascal");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Louis Pasteurs");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Charles Darwin");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Louis Pasteurs");
        }
        else if (maximoPerguntas == 59)
        {
            perguntaAle = ("As pessoas de qual tipo sanguíneo são consideradas doadores universais?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("A");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("B");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("O");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("AB");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("O");
        }
        else if (maximoPerguntas == 60)
        {
            perguntaAle = ("O que você coloca em uma torradeira? ");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("torrada");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("torresmo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("bolo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("pão");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("torrada");
        }
        else if (maximoPerguntas == 61)
        {
            perguntaAle = ("Na matemática qual número deriva de sí mesmo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("e");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("2");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("números primos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("10");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("e");
        }
        else if (maximoPerguntas == 62)
        {
            perguntaAle = ("Em que espécie se encontra os humanos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Equinos");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Canis Familiaris");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Proboscídeos Elefantídeos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Homo Sapiens");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Homo Sapiens");
        }
        else if (maximoPerguntas == 63)
        {
            perguntaAle = ("Atualmente qual é o sistema operacional desktop mais utilizado no mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Windows 10");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Windons XP");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Mac");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Android");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Windows 10");
        }
        else if (maximoPerguntas == 64)
        {
            perguntaAle = ("Qual o país mais extenso da América do Sul?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Argentina");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Estados Unidos");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Brasil");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Peru");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Brasil");
        }
        else if (maximoPerguntas == 65)
        {
            perguntaAle = ("Em que ano foi promulgada a atual constituição brasileira?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("1990");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1888");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("1950");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("1988");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("1988");
        }
        else if (maximoPerguntas == 66)
        {
            perguntaAle = ("Em que ano teve inicio o regime militar no brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("1988");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1764");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("1964");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("2019");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("1964");
        }
        else if (maximoPerguntas == 67)
        {
            perguntaAle = ("Qual a mais próxima estrela vizinha conhecida do Sol?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Alpha Centauri");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Alpha Tauri");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Sol");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Arcturus");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Alpha Centauri");
        }
        else if (maximoPerguntas == 68)
        {
            perguntaAle = ("O nosso Sol é uma:");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Anã branca");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Gigante amarela");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Anã Amarela");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Gigante vermelha");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Anã Amarela");
        }
        else if (maximoPerguntas == 69)
        {
            perguntaAle = ("Qual o processo de conversão no nucleo de uma estrela anã amarela pela fusão nuclear?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Hidrogênio para hélio");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Hélio para hidrogênio");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Oxigênio para ferro");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Nitrogênio para hélio");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Hidrogênio para hélio");
        }
        else if (maximoPerguntas == 70)
        {
            perguntaAle = ("Qual a composição química da água?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("CO2");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("H2O");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("CO3");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("H3O");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("H2O");
        }
        return 0;
    }

    //----------------- INICIO DO UPDATE--------------------

    void Update()
    {
            perguntasFeitas[idPergunta] = maximoPerguntas;

            perguntas[idPergunta] = perguntaAle;
            alternativaA[idPergunta] = respostaAleA;
            alternativaB[idPergunta] = respostaAleB;
            alternativaC[idPergunta] = respostaAleC;
            alternativaD[idPergunta] = respostaAleD;
            corretas[idPergunta] = respostaCorreta;
        
        //--------------- EFEITO DOS TROFEIS--------------------
        if (trofeu == 30)
        {            trofeuBronze.SetActive(true);
            balao.SetActive(false);
            estrela.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            tempoCongela = 1;
            brilho.SetActive(true);
            EfeitoSom.Instance.fogos.Stop();
        }

        if (trofeu == 60)
        {
            trofeuPrata.SetActive(true);
            balao.SetActive(false);
            estrela.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            
            tempoCongela = 1;
            brilho.SetActive(true);
            EfeitoSom.Instance.fogos.Stop();
        }
        
        if (trofeu == 100)
        {
            trofeuOuro.SetActive(true);
            balao.SetActive(false);
            estrela.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
           
            tempoCongela = 1;
            brilho.SetActive(true);
            EfeitoSom.Instance.fogos.Stop();
        }

        if(trofeu == 29)
        {
            EfeitoSom.Instance.trofeu.Play();
        }

        if (trofeu == 59)
        {
            EfeitoSom.Instance.trofeu.Play();
        }

        if (trofeu == 99)
        {
            EfeitoSom.Instance.trofeu.Play();
        }

        if(trofeu > 29)
        {
            Trofeus.salaTrofeu = true;
        }

        if (trofeu > 59)
        {
            Trofeus.salaTrofeu2 = true;
        }

        if (trofeu > 99)
        {
            Trofeus.salaTrofeu3 = true;          
        }

        if (tempo > 10)
        {
            tempoBat = true;
        }
        else
        {
            tempoBat = false;
        }

        if (tempoBat)
        {
            EfeitoSom.Instance.batimento.Play();
        }
        
            // CONDIÇÃO PARA DECORRER DO TEMPO
            if (tempoCongela == 0)
            {
                tempo -= Time.deltaTime;
                tempoText.text = tempo.ToString("0");
            }

            // CONDIÇÃO DE VITÓRIA
            if ((fim == vitoria) && (vida != 0))
            {
                tempoCongela = 1;
                Invoke("Vitoria", 3f);

            }

            if ((tempo <= 0) && (vida != 0))
            {
                pergunta.text = ("Sinto muito, mas o tempo acabou. Próxima pergunta!");

                EfeitoSom.Instance.pena.Play();
                botaoA.SetActive(false);
                botaoB.SetActive(false);
                botaoC.SetActive(false);
                botaoD.SetActive(false);
                EfeitoSom.Instance.batimento.Stop();
                tempoCongela = 1;
                tempo = 0.5f;

                Invoke("proximaPergunta", 3f);
                vida--;

                fim++;
            }

            // EXECUTA O EFEITO DA PERDA DE CORAÇÕES

            if (vida == 2)
            {
                vida1.SetActive(false);
            }

            if (vida == 1)
            {
                vida2.SetActive(false);
            }

            if ((vida == 0) && (tempo != 0))
            {
                vida3.SetActive(false);
                Invoke("FimJogo", 3f);
                pergunta.text = ("Sinto muito, mas suas vidas acabaram.");
                botaoA.SetActive(false);
                botaoB.SetActive(false);
                botaoC.SetActive(false);
                botaoD.SetActive(false);
                tempoCongela = 1;
                EfeitoSom.Instance.musicaTema.Stop();
            }
    }
    // FIM DO UPDATE ------------------------------------------------------------------------
    public void Inicio()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void bronzeOff()
    {
        trofeuBronze.SetActive(false);
        balao.SetActive(true);
        brilho.SetActive(false);

        tempoCongela = 0;
        trofeu += 1;   
    }

    public void prataOff()
    {
        trofeuPrata.SetActive(false);
        balao.SetActive(true);
        brilho.SetActive(false);
        
        tempoCongela = 0;
        trofeu += 1;
    }

    public void OuroOff()
    {
        trofeuOuro.SetActive(false);
        balao.SetActive(true);
        brilho.SetActive(false);
       
        tempoCongela = 0;
        trofeu += 1;
    }

    public void Correto()
    {
        correto.SetActive(false);
        trofeu += 1;
        PlayerPrefs.SetInt("LocalTrofeu", trofeu);
        PlayerPrefs.SetInt("TrofeuV", 1);
        proximaPergunta();
    }

    public void SomAtivo()
    {
        notaMusical.SetActive(true);
        som.SetActive(true);
        notaMusicalDesativado.SetActive(false);
    }
    public void SomDesativado()
    {
        notaMusical.SetActive(false);
        som.SetActive(false);
        notaMusicalDesativado.SetActive(true);
    }

    public void Errado()
    {
        errado.SetActive(false);
        proximaPergunta();
    }

    public void cenaTrofeus()
    {
        SceneManager.LoadScene("Trofeus");
    }

    public void Login()
    {
        SceneManager.LoadScene("Login");
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Voltar()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    public void Jogar()
    {
        SceneManager.LoadScene("Cena1");
    }

    public void Empresa()
    {
        SceneManager.LoadScene("Empresa");
    }

    void FimJogo()
    {
        fimJogo.SetActive(true);
        Invoke("Voltar", 5f);
        tempoCongela = 1;
    }

    public void Pulei()
    {
        pergunta.text = ("Pulou! Próxima pergunta.");
        Invoke("proximaPergunta", 3f);
        fim++;
        puloEfeito.SetActive(true);
        tempoCongela = 1;
        Invoke("AnimacaoPulo", 0.7f);
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        EfeitoSom.Instance.pulo.Play();
        botaoPulo.GetComponent<Button>().enabled = false;
        botaoPulo.GetComponent<Image>().color = Color.gray;
    }

    void AnimacaoPulo()
    {
        puloEfeito.SetActive(false);
    }

    void Vitoria()
    {
        pergunta.text = ("Meus parabéns! Você sobrevivel até a última pergunta.");
        venceu.SetActive(true);
        botaoA.SetActive(false);
        botaoB.SetActive(false);
        botaoC.SetActive(false);
        botaoD.SetActive(false);
    }

    void Ponto500()
    {
        ponto500.text = null;
    }

    void CertoA()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.green;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        correto.SetActive(true);
        EfeitoSom.Instance.acerto.Play();
        pontos += tempo + 500;
        pontuacao.text = pontos.ToString();
        ponto500.text = ("+500");
        Invoke("Ponto500", 4f);

        estrela.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        EfeitoSom.Instance.fogos.Play();
    }

    void ErradoA()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.red;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        respCorreto.text = respostaCorreta;
        EfeitoSom.Instance.pena.Play();
        errado.SetActive(true);
        vida--;
    }

    void CertoB()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.green;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        correto.SetActive(true);
        EfeitoSom.Instance.acerto.Play();
        pontos += tempo + 500;
        pontuacao.text = pontos.ToString();
        ponto500.text = ("+500");
        Invoke("Ponto500", 4f);

        estrela.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        EfeitoSom.Instance.fogos.Play();
    }

    void ErradoB()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.red;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        respCorreto.text = respostaCorreta;
        EfeitoSom.Instance.pena.Play();
        errado.SetActive(true);
        vida--;
    }

    void CertoC()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.green;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        correto.SetActive(true);
        EfeitoSom.Instance.acerto.Play();
        pontos += tempo + 500;
        pontuacao.text = pontos.ToString();
        ponto500.text = ("+500");
        Invoke("Ponto500", 4f);

        estrela.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        EfeitoSom.Instance.fogos.Play();
    }

    void ErradoC()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.red;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.gray;
        respCorreto.text = respostaCorreta;
        EfeitoSom.Instance.pena.Play();
        errado.SetActive(true);
        vida--;
    }

    void CertoD()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.green;
        correto.SetActive(true);
        EfeitoSom.Instance.acerto.Play();
        pontos += tempo + 500;
        pontuacao.text = pontos.ToString();
        ponto500.text = ("+500");
        Invoke("Ponto500", 4f);

        estrela.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        EfeitoSom.Instance.fogos.Play();
    }

    void ErradoD()
    {
        botaoA.GetComponent<Button>().enabled = false;
        botaoA.GetComponent<Image>().color = Color.gray;
        botaoB.GetComponent<Button>().enabled = false;
        botaoB.GetComponent<Image>().color = Color.gray;
        botaoC.GetComponent<Button>().enabled = false;
        botaoC.GetComponent<Image>().color = Color.gray;
        botaoD.GetComponent<Button>().enabled = false;
        botaoD.GetComponent<Image>().color = Color.red;
        respCorreto.text = respostaCorreta;
        EfeitoSom.Instance.pena.Play();
        errado.SetActive(true);
        vida--;
    }

    public void quiz(string alternativa)
    {
            if ((alternativa == "A") && (tempo > 0))
            {

                if (alternativaA[idPergunta] == respostaCorreta)
                {
                    pergunta.text = null;
                    fim++;

                    Invoke("CertoA", 2f);
                    EfeitoSom.Instance.batimento.Stop();
                    tempoCongela = 1;
                    botaoA.GetComponent<Button>().enabled = false;

                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                }
                else
                {
                    pergunta.text = null;

                    Invoke("ErradoA", 3f);

                    EfeitoSom.Instance.batimento.Stop();

                    botaoA.GetComponent<Button>().enabled = false;

                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                    fim++;
                    tempoCongela = 1;
                }
            }
            else if ((alternativa == "B") && (tempo > 0))
            {
                if (alternativaB[idPergunta] == respostaCorreta)
                {
                    pergunta.text = null;
                    fim++;

                    Invoke("CertoB", 2f);
                    EfeitoSom.Instance.batimento.Stop();
                    tempoCongela = 1;
                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;

                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                }
                else
                {
                    pergunta.text = null;

                    Invoke("ErradoB", 3f);

                    EfeitoSom.Instance.batimento.Stop();

                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;

                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                    fim++;
                    tempoCongela = 1;
                }
            }
            else if ((alternativa == "C") && (tempo > 0))
            {
                if (alternativaC[idPergunta] == respostaCorreta)
                {
                    pergunta.text = null;
                    fim++;

                    Invoke("CertoC", 2f);
                    EfeitoSom.Instance.batimento.Stop();
                    tempoCongela = 1;
                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;

                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                }

                else
                {
                    pergunta.text = null;

                    Invoke("ErradoC", 3f);

                    EfeitoSom.Instance.batimento.Stop();

                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;

                    botaoD.GetComponent<Button>().enabled = false;
                    botaoD.GetComponent<Image>().color = Color.gray;
                    fim++;
                    tempoCongela = 1;
                }
            }
            else if ((alternativa == "D") && (tempo > 0))
            {
                if (alternativaD[idPergunta] == respostaCorreta)
                {
                    pergunta.text = null;
                    fim++;

                    Invoke("CertoD", 2f);
                    EfeitoSom.Instance.batimento.Stop();
                    tempoCongela = 1;
                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;
                }
                else
                {
                    pergunta.text = null;

                    Invoke("ErradoD", 3f);

                    EfeitoSom.Instance.batimento.Stop();

                    botaoA.GetComponent<Button>().enabled = false;
                    botaoA.GetComponent<Image>().color = Color.gray;
                    botaoB.GetComponent<Button>().enabled = false;
                    botaoB.GetComponent<Image>().color = Color.gray;
                    botaoC.GetComponent<Button>().enabled = false;
                    botaoC.GetComponent<Image>().color = Color.gray;
                    botaoD.GetComponent<Button>().enabled = false;                  
                    fim++;
                    tempoCongela = 1;
                }
            }
    }

   
    int proximaPergunta()
    {
            estrela.SetActive(false);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
            EfeitoSom.Instance.fogos.Stop();

            EfeitoSom.Instance.pena.Stop();

            idPergunta++;

            perguntas.Add(perguntaAle);
            alternativaA.Add(respostaAleA);
            alternativaB.Add(respostaAleB);
            alternativaC.Add(respostaAleC);
            alternativaD.Add(respostaAleD);
            corretas.Add(respostaCorreta);

            tempo = 30;
            botaoA.SetActive(true);
            botaoB.SetActive(true);
            botaoC.SetActive(true);
            botaoD.SetActive(true);          

            tempoCongela = 0;

        Color impacto = new Color32(226, 110, 11, 255);
        botaoA.GetComponent<Image>().color = impacto;
        botaoB.GetComponent<Image>().color = impacto;
        botaoC.GetComponent<Image>().color = impacto;
        botaoD.GetComponent<Image>().color = impacto;

            botaoA.GetComponent<Button>().enabled = true;
            botaoB.GetComponent<Button>().enabled = true;
            botaoC.GetComponent<Button>().enabled = true;
            botaoD.GetComponent<Button>().enabled = true;
        
            perguntasFeitas.Add(maximoPerguntas);

            maximoPerguntas = Random.Range(minimo, maximo);

            while (perguntasFeitas.Contains(maximoPerguntas) && fim != 40)
            {
                return proximaPergunta();
            }

            if (maximoPerguntas == 1)
            {
                perguntaAle = ("Quanto é 1 + 1?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("2");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("3");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("5");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("8");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("2");
            }
            else if (maximoPerguntas == 2)
            {
                perguntaAle = ("Quem descobriu o Brasil?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Dom João VI");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Alexandre o Grande");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Dom Pedro I");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Pedro Alvarez Cabral");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Pedro Alvarez Cabral");
            }
            else if (maximoPerguntas == 3)
            {
                perguntaAle = ("Qual desses números é maior que 10?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("9");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("8");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("11");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("5");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("11");
            }
            else if (maximoPerguntas == 4)
            {
                perguntaAle = ("Qual desses físicos criou a teoria geral de relatividade?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Isaac Newton");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Galileo Galilei");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Wilhelm Röntgen");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Albert Einstein");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Albert Einstein");
            }
            else if (maximoPerguntas == 5)
            {
                perguntaAle = ("De quem é a famosa frase “Penso, logo existo”?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Platão");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Galileu Galilei");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Descartes");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Sócrates");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Descartes");
            }
            else if (maximoPerguntas == 6)
            {
                perguntaAle = ("De onde é a invenção do chuveiro elétrico?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("França");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Inglaterra");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Brasil");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Austrália");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Brasil");
            }
            else if (maximoPerguntas == 7)
            {
                perguntaAle = ("Qual o nome do presidente do Brasil que ficou conhecido como Jango?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("João Goulart");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Jacinto Anjos");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Getúlio Vargas");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("João Figueiredo");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("João Goulart");
            }
            else if (maximoPerguntas == 8)
            {
                perguntaAle = ("O que a palavra legend significa em português?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Legenda");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Conto");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("História");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Lenda");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Lenda");
            }

            else if (maximoPerguntas == 9)
            {
                perguntaAle = ("Qual o livro mais vendido no mundo a seguir à Bíblia?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("O Senhor dos Anéis");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Dom Quixote");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("O Pequeno Príncipe");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Ela, a Feiticeira");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Dom Quixote");
            }
            else if (maximoPerguntas == 10)
            {
                perguntaAle = ("Quantas casas decimais tem o número pi?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Duas");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Centenas");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Trilhares");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Vinte");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Trilhares");
            }
            else if (maximoPerguntas == 11)
            {
                perguntaAle = ("Atualmente, quantos elementos químicos a tabela periódica possui?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("113");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("109");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("108");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("118");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("118");
            }
            else if (maximoPerguntas == 12)
            {
                perguntaAle = ("Quais os países que têm a maior e a menor expectativa de vida do mundo?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Japão e Serra Leoa");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Austrália e Afeganistão");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Itália e Chade");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Brasil e Congo");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Japão e Serra Leoa");
            }
            else if (maximoPerguntas == 13)
            {
                perguntaAle = ("Qual o grupo em que todas as palavras foram escritas corretamente?");
                pergunta.text = perguntaAle.ToString();
                respostaAleA = ("Asterístico, beneficiente, meteorologia");
                respostaA.text = respostaAleA.ToString();
                respostaAleB = ("Asterisco, beneficinte, meteorologia");
                respostaB.text = respostaAleB.ToString();
                respostaAleC = ("Asterisco, beneficente, metereologia");
                respostaC.text = respostaAleC.ToString();
                respostaAleD = ("Asterisco, beneficente, meteorologia");
                respostaD.text = respostaAleD.ToString();
                respostaCorreta = ("Asterisco, beneficente, meteorologia");
            }
        else if (maximoPerguntas == 14)
        {
            perguntaAle = ("Quais o menor e o maior país do mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Vaticano e Rússia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Nauru e China");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Mônaco e Canadá");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Malta e Estados Unidos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Vaticano e Rússia");
        }
        else if (maximoPerguntas == 15)
        {
            perguntaAle = ("Qual o número mínimo de jogadores numa partida de futebol?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("10");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("9");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("5");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("7");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("7");
        }
        else if (maximoPerguntas == 16)
        {
            perguntaAle = ("Quais os principais autores do Barroco no Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Gregório de Matos, Bento Teixeira e Manuel Botelho de Oliveira");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Miguel de Cervantes, Gregório de Matos e Danthe Alighieri");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Castro Alves, Bento Teixeira e Manuel Botelho de Oliveira");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Álvares de Azevedo, Gregório de Matos e Bento Teixeira");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Gregório de Matos, Bento Teixeira e Manuel Botelho de Oliveira");
        }
        else if (maximoPerguntas == 17)
        {
            perguntaAle = ("Quais as duas datas que são comemoradas em novembro?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Independência do Brasil e Dia da Bandeira");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Proclamação da República e Dia Nacional da Consciência Negra");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Dia do Médico e Dia de São Lucas");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dia de Finados e Dia Nacional do Livro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Proclamação da República e Dia Nacional da Consciência Negra");
        }
        else if (maximoPerguntas == 18)
        {
            perguntaAle = ("Quem pintou Guernica?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Paul Cézanne");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Pablo Picasso");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Diego Rivera");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Salvador Dalí");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Pablo Picasso");
        }
        else if (maximoPerguntas == 19)
        {
            perguntaAle = ("Quanto tempo a luz do Sol demora para chegar à Terra?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("12 minutos");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1 dia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("8 minutos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("segundos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("8 minutos");
        }
        else if (maximoPerguntas == 20)
        {
            perguntaAle = ("Qual a tradução da frase “Fabiano cogió su saco antes de salir”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Fabiano coseu seu paletó antes de sair");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Fabiano fechou o saco antes de sair");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Fabiano pegou seu paletó antes de sair");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Fabiano cortou o saco antes de cair");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Fabiano pegou seu paletó antes de sair");
        }
        else if (maximoPerguntas == 21)
        {
            perguntaAle = ("Qual a altura da rede de vôlei nos jogos masculino e feminino?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("2,5 m e 2,0 m");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1,8 m e 1,5 m");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("2,45 m e 2,15 m");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("2,43 m e 2,24 m");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("2,43 m e 2,24 m");
        }
        else if (maximoPerguntas == 22)
        {
            perguntaAle = ("Qual o nome do tratado comercial entre os países da América Latina?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Tratado de Tordesilhas");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Mercosul");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("EuroÁsia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Hermanos Econômicos");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Mercosul");
        }
        else if (maximoPerguntas == 23)
        {
            perguntaAle = ("Em quantas camadas se divide uma célula?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("2");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("4");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("3");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("5");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("3");
        }
        else if (maximoPerguntas == 24)
        {
            perguntaAle = ("Qual cidade foi capital do Brasil entre 1763 e 1961?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Salvador");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Brasília");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Tocantins");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Rio de janeiro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Rio de janeiro");
        }
        else if (maximoPerguntas == 25)
        {
            perguntaAle = ("A teoria do ''Salto Quântico'' explica o comportamento peculiar dos elétrons saltando entre as camadas de um átomo.De qual campo científico pertence essa teoria ? ");
       
                   pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Matemática");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Química");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Física");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Paleontologia");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Física");
        }
        else if (maximoPerguntas == 26)
        {
            perguntaAle = ("Qual o maior satélite natural de Júpiter");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Terra");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Lua");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Ganímedes");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Órion");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Ganímedes");
        }
        else if (maximoPerguntas == 27)
        {
            perguntaAle = ("Qual satélite de Jupiter é coberto por gelo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Europa");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Ganímedes");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Io");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Calisto");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Europa");
        }
        else if (maximoPerguntas == 28)
        {
            perguntaAle = ("Em que ordem surgiram os modelos atômicos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Thomson, Dalton, Rutherford, Rutherford-Bohr");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rutherford-Bohr, Rutherford, Thomson, Dalton");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Dalton, Thomson, Rutherford-Bohr, Rutherford");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dalton, Thomson, Rutherford, Rutherford-Bohr");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Dalton, Thomson, Rutherford, Rutherford-Bohr");
        }
        else if (maximoPerguntas == 29)
        {
            perguntaAle = ("Em que período da pré-história o fogo foi descoberto?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Neolítico");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Paleolítico");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Idade dos Metais");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Período da Pedra Polida");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Paleolítico");
        }
        else if (maximoPerguntas == 30)
        {
            perguntaAle = ("Qual das alternativas abaixo apenas contêm classes de palavras?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Vogais, semivogais e consoantes");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Artigo, verbo transitivo e verbo intransitivo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Hiatos, ditongos e tritongos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Substantivo, verbo e preposição");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Substantivo, verbo e preposição");
        }
        else if (maximoPerguntas == 31)
        {
            perguntaAle = ("Qual a montanha mais alta do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Pico da Neblina");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Pico Paraná");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Monte Roraima");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Pico Maior de Friburgo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Pico da Neblina");
        }
        else if (maximoPerguntas == 32)
        {
            perguntaAle = ("Qual a velocidade da luz?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("300 000 000 metros por segundo (m/s)");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("150 000 000 metros por segundo (m/s)");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("199 792 458 metros por segundo (m/s)");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("299 792 458 metros por segundo (m/s)");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("299 792 458 metros por segundo (m/s)");
        }
        else if (maximoPerguntas == 33)
        {
            perguntaAle = ("Em qual local da Ásia o português é a língua oficial?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Índia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Filipinas");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Macau");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Portugal");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Macau");
        }
        else if (maximoPerguntas == 34)
        {
            perguntaAle = ("“It is six twenty ou twenty past six”. Que horas são em inglês?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("12:06");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("6:20");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("2:20");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("6:02");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("6:20");
        }
        else if (maximoPerguntas == 35)
        {
            perguntaAle = ("Quem é o autor de “O Príncipe”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Maquiavel");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Antoine de Saint-Exupéry");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Montesquieu");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Thomas Hobbes");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Maquiavel");
        }
        else if (maximoPerguntas == 36)
        {
            perguntaAle = ("Quantos dias possui o ano bissexto?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("250");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("365");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("366");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("266");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("366");
        }
        else if (maximoPerguntas == 37)
        {
            perguntaAle = ("Atuamente qual a capital do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Brasília");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rio de Janeiro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("São Paulo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Salvador");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Brasília");
        }
        else if (maximoPerguntas == 38)
        {
            perguntaAle = ("Qual foi a primeira capital do Brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Salvador");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rio de Janeiro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Brasília");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Fortaleza");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Salvador");
        }
        else if (maximoPerguntas == 39)
        {
            perguntaAle = ("Quais são as cores primárias, também conhecidas como cores puras?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Azul, preto e branco");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Azul, vermelho e amarelo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Roxo, preto e rosa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Vermelho, amarelo e verde");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Azul, vermelho e amarelo");
        }
        else if (maximoPerguntas == 40)
        {
            perguntaAle = ("Quantas cores possui um arco-íris");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("5");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("8");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("7");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("4");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("7");
        }
        else if (maximoPerguntas == 41)
        {
            perguntaAle = ("Quais destas doenças são sexualmente transmissíveis?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Chikungunya, aids e herpes genital");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Aids, tricomoníase e ebola");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Gonorreia, clamídia e sífilis");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Hepatite B, febre tifoide e hanseníase");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Gonorreia, clamídia e sífilis");
        }
        else if (maximoPerguntas == 42)
        {
            perguntaAle = ("Como é a conjugação do verbo caber na 1.ª pessoa do singular do presente do indicativo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Eu caibo");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Ele cabe");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Que eu caiba");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Eu cabo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Eu caibo");
        }
        else if (maximoPerguntas == 43)
        {
            perguntaAle = ("Quais destas construções famosas ficam nos Estados Unidos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Estátua da Liberdade, Golden Gate Bridge e Empire State Building");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Estátua da Liberdade, Big Ben e The High Line");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Angkor Wat, Taj Mahal e Skywalk no Grand Canyon");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Lincoln Memorial, Sidney Opera House e Burj Khalifa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Estátua da Liberdade, Golden Gate Bridge e Empire State Building");
        }
        else if (maximoPerguntas == 44)
        {
            perguntaAle = ("Qual destes países é transcontinental?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Filipinas");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Rússia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Tanzânia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Istambul");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Rússia");
        }
        else if (maximoPerguntas == 45)
        {
            perguntaAle = ("Em qual das orações abaixo a palavra foi empregada incorretamente?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Mais uma vez, portou-se mal");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("É um homem mal");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Esse é o mal de todos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("É um mau vendedor");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("É um homem mal");
        }
        else if (maximoPerguntas == 46)
        {
            perguntaAle = ("Qual foi o recurso utilizado inicialmente pelo homem para explicar a origem das coisas?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("A Filosofia");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("A Biologia");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("A Astronomia");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("A Mitologia");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("A Mitologia");
        }
        else if (maximoPerguntas == 47)
        {
            perguntaAle = ("Quais os planetas do sistema solar?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Terra, Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Júpiter, Marte, Mercúrio, Netuno, Plutão, Saturno, Terra, Urano, Vênus");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Júpiter, Marte, Mercúrio, Netuno, Plutão, Saturno, Sol, Terra, Urano, Vênus");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Terra, Vênus, Saturno, Urano, Júpiter, Marte, Netuno, Mercúrio");
        }
        else if (maximoPerguntas == 48)
        {
            perguntaAle = ("Qual era o nome de Aleijadinho?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Alexandrino Francisco Lisboa");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Manuel Francisco Lisboa");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Antônio Francisco Lisboa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Francisco Antônio Lisboa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Antônio Francisco Lisboa");
        }
        else if (maximoPerguntas == 49)
        {
            perguntaAle = (" Júpiter e Plutão são os correlatos romanos de quais deuses gregos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Ares e Hermes");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Cronos e Apolo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Zeus e Hades");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Dionísio e Deméter");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Zeus e Hades");
        }
        else if (maximoPerguntas == 50)
        {
            perguntaAle = ("Qual o maior animal terrestre?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Baleia Azul");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Dinossauro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Elefante africano");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Girafa");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Elefante africano");
        }
        else if (maximoPerguntas == 51)
        {
            perguntaAle = ("Qual o tema do famoso discurso Eu Tenho um Sonho, de Martin Luther King?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Igualdade entre as etnias");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Justiça para os menos favorecidos");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Intolerância religiosa");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Luta contra o Apartheid");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Igualdade entre as etnias");
        }
        else if (maximoPerguntas == 52)
        {
            perguntaAle = ("Que líder mundial ficou conhecida como “Dama de Ferro”?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Dilma Rousseff");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Margaret Thatcher");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Hillary Clinton");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Christine Lagarde");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Margaret Thatcher");
        }
        else if (maximoPerguntas == 53)
        {
            perguntaAle = ("Quais os nomes dos três Reis Magos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Gaspar, Nicolau e Natanael");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Belchior, Gaspar e Baltazar");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Belchior, Gaspar e Nataniel");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Melchior, Noé e Galileu");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Belchior, Gaspar e Baltazar");
        }
        else if (maximoPerguntas == 54)
        {
            perguntaAle = ("Qual a religião monoteísta que conta com o maior número de adeptos no mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Judaísmo");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Zoroastrismo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Cristianismo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Islamismo");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Cristianismo");
        }
        else if (maximoPerguntas == 55)
        {
            perguntaAle = ("Qual desses filmes foi baseado na obra de Shakespeare?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Muito Barulho por Nada (2012)");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Capitães de Areia (2011)");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("A Dama das Camélias (1936)");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Excalibur (1981)");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Muito Barulho por Nada (2012)");
        }
        else if (maximoPerguntas == 56)
        {
            perguntaAle = ("Quem foi o primeiro homem a pisar na Lua? Em que ano aconteceu?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Yuri Gagarin, em 1961");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Neils Armstrong, em 1969");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Buzz Aldrin, em 1969");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Charles Duke, em 1971");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Neils Armstrong, em 1969");
        }
        else if (maximoPerguntas == 57)
        {
            perguntaAle = ("Em qual data se comemora o Natal?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("23 de dezembro");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("24 de dezembro");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("25 de novembro");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("25 de dezembro");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("25 de dezembro");
        }
        else if (maximoPerguntas == 58)
        {
            perguntaAle = ("Qual o nome do cientista que descobriu o processo de pasteurização e a vacina contra a raiva?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Marie Curie");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Blaise Pascal");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Louis Pasteurs");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Charles Darwin");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Louis Pasteurs");
        }
        else if (maximoPerguntas == 59)
        {
            perguntaAle = ("As pessoas de qual tipo sanguíneo são consideradas doadores universais?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("A");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("B");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("O");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("AB");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("O");
        }
        else if (maximoPerguntas == 60)
        {
            perguntaAle = ("O que você coloca em uma torradeira? ");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("torrada");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("torresmo");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("bolo");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("pão");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("torrada");
        }
        else if (maximoPerguntas == 61)
        {
            perguntaAle = ("Na matemática qual número deriva de sí mesmo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("e");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("2");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("números primos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("10");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("e");
        }
        else if (maximoPerguntas == 62)
        {
            perguntaAle = ("Qual a espécie dos humanos?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Equinos");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Canis Familiaris");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Proboscídeos Elefantídeos");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Homo Sapiens");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Homo Sapiens");
        }
        else if (maximoPerguntas == 63)
        {
            perguntaAle = ("Atualmente qual é o sistema operacional desktop mais utilizado no mundo?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Windows 10");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Windons XP");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Mac");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Android");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Windows 10");
        }
        else if (maximoPerguntas == 64)
        {
            perguntaAle = ("Qual o país mais extenso da América do Sul?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Argentina");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Estados Unidos");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Brasil");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Peru");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Brasil");
        }
        else if (maximoPerguntas == 65)
        {
            perguntaAle = ("Em que ano foi promulgada a atual constituição brasileira?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("1990");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1888");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("1950");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("1988");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("1988");
        }
        else if (maximoPerguntas == 66)
        {
            perguntaAle = ("Em que ano teve inicio o regime militar no brasil?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("1988");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("1764");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("1964");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("2019");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("1964");
        }
        else if (maximoPerguntas == 67)
        {
            perguntaAle = ("Qual a mais próxima estrela vizinha conhecida do Sol?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Alpha Centauri");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Alpha Tauri");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Sol");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Arcturus");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Alpha Centauri");
        }
        else if (maximoPerguntas == 68)
        {
            perguntaAle = ("O nosso Sol é uma:");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Anã branca");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Gigante amarela");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Anã Amarela");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Gigante vermelha");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Anã Amarela");
        }
        else if (maximoPerguntas == 69)
        {
            perguntaAle = ("Qual o processo de conversão no nucleo de uma estrela anã amarela pela fusão nuclear?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("Hidrogênio para hélio");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("Hélio para hidrogênio");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("Oxigênio para ferro");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("Nitrogênio para hélio");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("Hidrogênio para hélio");
        }
        else if (maximoPerguntas == 70)
        {
            perguntaAle = ("Qual a composição química da água?");
            pergunta.text = perguntaAle.ToString();
            respostaAleA = ("CO2");
            respostaA.text = respostaAleA.ToString();
            respostaAleB = ("H2O");
            respostaB.text = respostaAleB.ToString();
            respostaAleC = ("CO3");
            respostaC.text = respostaAleC.ToString();
            respostaAleD = ("H3O");
            respostaD.text = respostaAleD.ToString();
            respostaCorreta = ("H2O");
        }
        return 0;
    }
}
