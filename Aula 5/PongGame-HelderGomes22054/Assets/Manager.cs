using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Score 01")]
    public GameObject score;

    private int playerScore;

    public void Player1Scored()
    {
        playerScore++;
        score.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        ball.GetComponent<Ball>().IncreaseSpeed();

    }

    public void Reset()
    {
        playerScore = 0;
        score.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
    }

}