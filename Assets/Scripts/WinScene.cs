using UnityEngine;
using UnityEngine.SceneManagement;
public class WinScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("LoadMainMenu",3);
    }

    // Update is called once per frame
    
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
