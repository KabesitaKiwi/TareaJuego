using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void ReiniciarJuego()
    {
        
        SceneManager.LoadScene("nivel1");
    }

    public void IrAlMenuPrincipal()
    {
        SceneManager.LoadScene("MainMenu");
    }
}