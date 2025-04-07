using UnityEngine;

public class MovingRoad : MonoBehaviour
{
    public float speed = 10.0f;
    private Material roadMaterial;

    void Start()
    {
        roadMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float offset = Time.time * speed;
        roadMaterial.mainTextureOffset = new Vector2(offset, 0);
    }
}