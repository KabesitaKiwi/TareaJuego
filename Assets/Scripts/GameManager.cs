using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public TMP_Text collectibleNumberText;

    private int collectibleNumber;

    public TMP_Text totalCollectibleNumberText;
    private int totalCollectibleNumber;
    // Start is called before the first frame update
    void Start()
    {
        totalCollectibleNumber = transform.childCount;
        totalCollectibleNumberText.text = totalCollectibleNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }


    public void AddCollectible()
    {
        collectibleNumber++;
        collectibleNumberText.text = collectibleNumber.ToString();
    }
}
