using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Manager : MonoBehaviour
{

    void Start()
    {
        // Verifica��o de refer�ncias
        if (Result == null) Debug.LogError("Result is not assigned!");
        if (AIChoice == null) Debug.LogError("AIChoice is not assigned!");
        if (Choices == null || Choices.Length == 0) Debug.LogError("Choices array is not initialized!");
    }


    public TMP_Text Result;
    public Image AIChoice;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    public void Play(string myChoice)
    {
        string randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        {
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Empate!";
                        break;

                    case "Paper":
                        Result.text = "O papel vence a pedra. Voc� ganhou! :D";
                        break;

                    case "Scissors":
                        Result.text = "A pedra vence a tesoura. Voc� perdeu :(";
                        break;
                }

                AIChoice.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "O papel vence a pedra. Voc� perdeu :(";
                        break;

                    case "Paper":
                        Result.text = "Empate!";
                        break;

                    case "Scissors":
                        Result.text = "A tesoura vence o papel. Voc� ganhou! :D";
                        break;
                }

                AIChoice.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "A pedra vence a tesoura. Voc� ganhou! :D";
                        break;

                    case "Paper":
                        Result.text = "A tesoura vence o papel. Voc� perdeu :(";
                        break;

                    case "Scissors":
                        Result.text = "Empate!";
                        break;
                }

                AIChoice.sprite = Scissors;
                break;
        }
    }
}
