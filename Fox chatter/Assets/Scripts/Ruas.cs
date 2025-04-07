using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carros : MonoBehaviour
{
    private bool hasIntantiate = false;
    private float speed = -0.025f;

   
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0, speed, 0);
        if (transform.position.y <= -1.3f)
        {
            transform.position = new Vector3(2.25f, 17, 0);
        }




    }


}
