using UnityEngine;

public class DragAndDisappear : MonoBehaviour
{
    private bool isDragging = false;

    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                   
                    isDragging = true;
                }
            }
        }

      
        if (isDragging && Input.GetMouseButton(0))
        {
            
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.WorldToScreenPoint(transform.position).z;
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = worldPosition;
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
           
            isDragging = false;
            gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
      
        AudioSource audio = GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
    }
}
