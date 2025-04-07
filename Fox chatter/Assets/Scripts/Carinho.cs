using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    public GameObject roadPrefab; 
    public int numberOfRoads = 5;
    public float roadLength = 20f; 
    public float speed = 10f; 

    private GameObject[] roadSegments;
    private Vector3 startPosition;

    void Start()
    {
        roadSegments = new GameObject[numberOfRoads];

        // Inicializa os segmentos da pista
        for (int i = 0; i < numberOfRoads; i++)
        {
            roadSegments[i] = Instantiate(roadPrefab, new Vector3(0, 0, i * roadLength), Quaternion.identity);
        }

        startPosition = roadSegments[0].transform.position;
    }

    void Update()
    {
        // Move a pista na direção do jogador
        for (int i = 0; i < numberOfRoads; i++)
        {
            roadSegments[i].transform.Translate(Vector3.back * speed * Time.deltaTime);

            // Se o segmento estiver fora da tela, reposiciona-o para o início
            if (roadSegments[i].transform.position.z < startPosition.z - roadLength)
            {
                float newZ = roadSegments[i].transform.position.z + (roadLength * numberOfRoads);
                roadSegments[i].transform.position = new Vector3(roadSegments[i].transform.position.x, roadSegments[i].transform.position.y, newZ);
            }
        }
    }
}
