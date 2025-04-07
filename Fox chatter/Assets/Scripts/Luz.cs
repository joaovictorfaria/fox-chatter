using UnityEngine;

public class LampController : MonoBehaviour
{
    public Light lampLight;
    public Animator foxAnimator; 

    private bool isOn = true; 

    void OnMouseDown()
    {
        // Alterna a luz entre ligada e desligada
        isOn = !isOn;
        lampLight.enabled = isOn;

        // Se a luz for desligada, ativa a animação de deitar
        if (!isOn)
        {
            foxAnimator.SetTrigger("LayDown");
        }
    }
}
