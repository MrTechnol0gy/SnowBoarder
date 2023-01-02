using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int score;
    [SerializeField] int finishScore = 50;
    [SerializeField] int rideScore = 1;
    [SerializeField] int jumpScore = 3;

    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScoreText();
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreText();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            score = score + rideScore;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            score = score + finishScore;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        score = score + jumpScore;
    }
}
