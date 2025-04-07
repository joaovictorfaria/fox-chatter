using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroAmarelo : MonoBehaviour
{
    float speed = 5f;
    bool over = false;

    void Start()
    {
        over = false;
        speed = 0.01f;
        transform.position = new Vector3(1.5f * Random.Range(0, 4), Random.Range(14, 19), -1);
    }

    void Update()
    {
        if (!over)
        {
            transform.position += new Vector3(0, -speed, 0);
        }

        if (transform.position.y <= 0.5f)
        {
            speed += Random.Range(0.001f, 0.004f);
            transform.position = new Vector3(1.5f * Random.Range(0, 4), Random.Range(14, 19), -1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<AudioSource>().Play();
        over = true;
    }

    public void Comecar()
    {
        Start();
    }
}
