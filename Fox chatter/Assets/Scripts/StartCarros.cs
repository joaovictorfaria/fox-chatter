using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCarros : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(true);
    }

    public void Comecar()
    {
        gameObject.SetActive(false);
    }
}
