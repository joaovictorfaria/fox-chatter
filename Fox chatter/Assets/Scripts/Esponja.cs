using UnityEngine;
using UnityEngine.EventSystems;

public class SpongeFoamWithoutParticles : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public GameObject foamPrefab; 
    public float foamSpawnInterval = 0.2f; 
    public float foamLifetime = 0.1f; 
    public AudioSource audioSource; 
    private bool isDragging = false;
    private float foamTimer = 0f; 

    private void Start()
    {
     
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;

      
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // Atualiza a posição da esponja
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.anchoredPosition += eventData.delta;

            // Controla o intervalo de criação da espuma
            foamTimer += Time.deltaTime;
            if (foamTimer >= foamSpawnInterval)
            {
                SpawnFoam();
                foamTimer = 0f;
            }
        }
    }

    private void SpawnFoam()
    {
       
        Vector3 spawnPosition = this.transform.position;
        GameObject foam = Instantiate(foamPrefab, spawnPosition, Quaternion.identity);

        // Destrói a espuma após o tempo de vida
        Destroy(foam, foamLifetime);
    }
}
