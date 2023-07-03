using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    int score;

     //Audio
    public AudioClip[] audioClip;
    AudioSource audioSource;

    //Death Screen
    public GameObject deathScreen;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    int highScore;

    void Start()
    {
        if (PlayerPrefs.HasKey("High Score"))
        {
            highScore = PlayerPrefs.GetInt("High Score");
        }
        else
        {
            highScore = 0;
        }

        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
             if (score > highScore)
            {
                PlayerPrefs.SetInt("High Score", score);
            }

            Destroy(gameObject);
            Time.timeScale = 0.0f;       
            deathScreen.SetActive(true);  
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("High Score");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Point")
        {               
            audioSource.PlayOneShot(audioClip[0]);

            score++;
            ChangeScoreUI();
        }
    }

    void ChangeScoreUI()
    {
        scoreText.text = score.ToString();
    }
}
