using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalImput;
    public float speed;

    public float xRange;

    public Transform blaster;
    public GameObject laserBolt;
    public AudioClip blasterSound;
    private AudioSource playerAudio;

    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Intialize horizontalInput to recive values from keyboard
        horizontalImput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalImput * Time.deltaTime * speed);

        // Left Player constraint boundry
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Right Player constraint boundry
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If spacebar is pressed, Create laserBolt at the blater transform position maintaining the objects rotation
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
            playerAudio.PlayOneShot(blasterSound, 1.0f);
        }

        
    }
    
    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);  
    }

}