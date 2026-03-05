using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Vida : MonoBehaviour
{
    public int vidas = 3;
    public float tiempoInvulnerabilidad = 1.5f;
    private float ultimoGolpe;

    
    public TextMeshProUGUI textoVidas; 

    void Start()
    {
        ActualizarInterfaz();
    }

    public void RecibirDano(int cantidad)
    {
        if (Time.time > ultimoGolpe + tiempoInvulnerabilidad)
        {
            vidas -= cantidad;
            ultimoGolpe = Time.time;
            
            ActualizarInterfaz(); 

            if (vidas <= 0)
            {
                Morir();
            }
        }
    }

    void ActualizarInterfaz()
    {
        if (textoVidas != null)
        {
            textoVidas.text = "Vidas: " + vidas.ToString();
        }
    }

    public void Morir()
    {
        Debug.Log("¡Has muerto!");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("GameOver");
    }
}