using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtividadesBanho : MonoBehaviour
{
    public GameObject BOTOES;
    public GameObject RAPOSA;
    public GameObject CAMERA;
    public GameObject PIVOT;

    bool sabonete = false;
    bool enxaguar = false;

    public void Sabonete()
    {
        if (!sabonete)
        {
            sabonete = true;
            BOTOES.SetActive(false);
            PIVOT.transform.localPosition = new Vector3(-450, -1100, 0);

            CAMERA.transform.rotation = Quaternion.Euler(15, -60, 0);
        }
        else
        {
            sabonete = false;
            BOTOES.SetActive(true);
            PIVOT.transform.localPosition = new Vector3(-450, -800, 0);

            CAMERA.transform.rotation = Quaternion.Euler(15, 30, 0);
        }

    }

    public void Enxaguar()
    {
        if (!enxaguar)
        {
            enxaguar = true;
            BOTOES.SetActive(false);
            PIVOT.transform.localPosition = new Vector3(-450, -1100, 0);

            CAMERA.transform.localPosition = new Vector3(3.5f, 2.75f, 7.5f);
            RAPOSA.transform.localPosition = new Vector3(2.3f, 0, 2);
        }
        else
        {
            enxaguar = false;
            BOTOES.SetActive(true);
            PIVOT.transform.localPosition = new Vector3(-450, -800, 0);

            CAMERA.transform.localPosition = new Vector3(1.5f, 2.75f, 5.8f);
            RAPOSA.transform.localPosition = new Vector3(0, 0, 0);
        }
    }

}