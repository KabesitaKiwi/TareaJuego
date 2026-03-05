using UnityEngine;

public class Trampas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Vida>(out Vida salud))
        {
            salud.Morir();
        }
    }
}
