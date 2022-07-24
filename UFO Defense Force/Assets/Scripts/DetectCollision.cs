using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;
    public AudioClip destroySound;
    private AudioSource destroyAudio;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameObject and reference ScoreMagager script component
        destroyAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        destroyAudio.PlayOneShot(destroySound, 1.0f);
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        Destroy(gameObject); // Destroy this gameObject
        Destroy(other.gameObject); // Destroy contacted gameObject
    }
}
