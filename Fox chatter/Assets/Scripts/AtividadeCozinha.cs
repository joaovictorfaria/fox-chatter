using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtividadeCozinha : MonoBehaviour
{
    public GameObject BOTOES;
    public GameObject RAPOSA;
    public GameObject CAMERA;
    public GameObject PIVOT;

    bool comer = false;

    public void Comer()
    {
        if (!comer)
        {
            comer = true;
            BOTOES.SetActive(false);
            PIVOT.transform.localPosition = new Vector3(-450, -1100, 0);

            CAMERA.transform.localPosition = new Vector3(-1.7f, 3, 5);
            RAPOSA.transform.localPosition = new Vector3(-2.71f, 0, -0.15f);
        }
        else
        {
            comer = false;
            BOTOES.SetActive(true);
            PIVOT.transform.localPosition = new Vector3(-450, -800, 0);

            CAMERA.transform.localPosition = new Vector3(1.5f, 2.75f, 5.8f);
            RAPOSA.transform.localPosition = new Vector3(0, 0, 0);
        }

    }
}
