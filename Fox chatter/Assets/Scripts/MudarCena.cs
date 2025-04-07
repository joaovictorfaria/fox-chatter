using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{

    public void irBanheiro()
    {
        SceneManager.LoadScene("banheiro");
    }

    public void irCozinha()
    {
        SceneManager.LoadScene("cozinha");
    }

    public void irQuarto()
    {
        SceneManager.LoadScene("quarto");
    }

    public void irQuadra()
    {
        SceneManager.LoadScene("quadra");
    }

    public void irJogo()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void irLuz()
    {
        SceneManager.LoadScene("Luz");
    }


      public void irGame()
    {
        SceneManager.LoadScene("Game");
    }

      public void irjokenpo()
    {
        SceneManager.LoadScene("jokenpo");
    }

      public void irJoke()
    {
        SceneManager.LoadScene("Joke");
    }

        public void irCarro()
    {
        SceneManager.LoadScene("Carro");
    }
}
