using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    public TextMeshProUGUI winner;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    public Sprite[] PlayerWin;
    public Image WinCondition;
    
    void Start()
    {
        if (GameManager.player1Score == GameManager.player2Score)
        {
            WinCondition.sprite = PlayerWin[2];
        }
        else if (GameManager.player1Score > GameManager.player2Score)
        {
            WinCondition.sprite = PlayerWin[0];
        }
        else
        {
            WinCondition.sprite = PlayerWin[1];
        }

        player1ScoreText.text = "Player 1: " + GameManager.player1Score;
        player2ScoreText.text = "Player 2: " + GameManager.player2Score;
    }
}
