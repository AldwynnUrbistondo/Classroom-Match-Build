using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button homeButton;
    public GameObject quitPanel;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void PauseGame()
    {
        if (gameManager.canClick)
        {
            gameManager.audioSource.clip = gameManager.cardClickSound;
            gameManager.audioSource.Play();

            gameManager.canClick = false;
            gameManager.timeIsRunning = false;

            homeButton.gameObject.SetActive(false);

            quitPanel.gameObject.SetActive(true);
        }
        
    }

    public void PlayGame()
    {
        gameManager.audioSource.clip = gameManager.cardClickSound;
        gameManager.audioSource.Play();

        gameManager.canClick = true;
        gameManager.timeIsRunning = true;
    }

    public void BackScene()
    {
        gameManager.audioSource.clip = gameManager.cardClickSound;
        gameManager.audioSource.Play();

        SceneManager.LoadScene("Start");
    }
}
