using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameObject and reference ScoreMagager script component
    }
    private void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        Destroy(gameObject); // Destroy this gameObject
        Destroy(other.gameObject); // Destroy contacted gameObject
    }
}
