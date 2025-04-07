using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CarroVermelho : MonoBehaviour
{
    int Pontos = 0;
    bool over = false;
    public GameObject GameOver;
    public TMP_Text Score;

    void Start()
    {
        over = false;
        Pontos = 0;
        Score.SetText("Pontos: 0");
        transform.position = new Vector3(0, 3.31f, -1);
    }

    void Update()
    {
        if (!over)
        {
            Pontos++;
            Score.SetText($"Pontos: {Pontos.ToString()}");


            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (transform.position.x >= 1)
                {
                    transform.position -= new Vector3(1.5f, 0, 0);
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (transform.position.x <= 4.4f)
                {
                    transform.position += new Vector3(1.5f, 0, 0);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Restart();
    }

    void Restart()
    {
        GameOver.SetActive(true);
        over = true;
    }

    public void Comecar()
    {
        Start();
    }
}
