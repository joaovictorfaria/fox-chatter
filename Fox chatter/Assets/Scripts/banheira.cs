using UnityEngine;

public class FoxMoveToBath : MonoBehaviour
{
    public Transform bathPosition;      
    public float stopDistance = 0.1f;   
    private Vector3 initialPosition;    
    private bool moveToBath = false;    
    private bool isInBath = false;     
    public GameObject camera;

    void Start()
    {
        initialPosition = transform.position;
    }

   
    public void MoveToBath()
    {
        moveToBath = true;
    }

    void Update()
    {
        if (moveToBath)
        {
            if (!isInBath)
            {
                // Teleporta para a banheira
                transform.position = bathPosition.position;
                camera.transform.localPosition = new Vector3(3.5f, 2.75f, 7);
                isInBath = true; 
                moveToBath = false;  
            }
            else
            {
                // Teleporta de volta para a posição inicial
                transform.position = initialPosition;
                camera.transform.localPosition = new Vector3(1.5f, 2.75f, 5.8f);
                isInBath = false;  
                moveToBath = false; 
            }
        }
    }
}
