using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{
    public float vidaPlayer;
    
    public int score;

    public int scoreAtual;

    public Text scoreText;
    
    public Image barraVida;

    public GameObject panel;

    public Vector3 posInicial;


    void Start()
    {
        posInicial = transform.position;

        score = 0;
        scoreAtual = 0;

        if(PlayerPrefs.HasKey("scoreAtual" + score))
        {
           scoreAtual = PlayerPrefs.GetInt("scoreAtual" + score);
        }
    }

    
    void Update()
    {
        Morte();
        Pontuacao();
    }

      private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Inimigo"))
        {
            vidaPlayer -= 10;
            barraVida.fillAmount = vidaPlayer / 100;
        }
    } 

    private void Pontuacao()
    {
      if(MoveZombie.vidaZombie <= 0)
      {
        score += 5;
        scoreText.text = score.ToString("SCORE:" + score);

        if(score > scoreAtual)
        {
          scoreAtual = score;
          PlayerPrefs.SetInt("score", scoreAtual);
          
        }
        
      }
    }

    private void Morte()
    {
      if(vidaPlayer <= 0)
      {
        panel.SetActive(true);
      }
    }

    public void Retry()
    {
       posInicial = transform.position;

       panel.SetActive(false);

       score = 0;
    }
}
