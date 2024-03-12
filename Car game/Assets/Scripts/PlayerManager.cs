 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject completeLevelUI;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale=0;
            gameOverPanel.SetActive(true);
        }
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
