using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    //player score
    public static int score;       
    Text scoreText; 

    void Awake()
    {
        // initilastion of text companent
        scoreText = GetComponent<Text>();
        // Reset the score if a new game
        score = 0;


    }

    void Update()
    {
        //set text on screen to score + score
        scoreText.text = "Score: " + score;
    }
}