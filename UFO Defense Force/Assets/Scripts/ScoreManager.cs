using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name space added to acces librarys for UI

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText; // Visual text element to be modified

    public void IncreaseScore(int amount) // This method increases the score by a predetermined amount set in the score variable when called
    {    
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // This method decreases the score by a predetermined amount set in the score variable when called
    {
        score -= amount;
        UpdateScoreText();
    }

    public void UpdateScoreText() // This method updates the score in the HUD UI text
    {
        scoreText.text = "Score: " + score;
    }
}
