using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthManagerScript : MonoBehaviour
{
    //player score
    public static int health;
   	Slider healthBar;
	Rigidbody healthBarBody;
	public float barSpeed;
	public Boundary boundary;

    void Awake()
    {
        // initilastion of text companent
        healthBar = GetComponent<Slider>();
		healthBarBody = GetComponent<Rigidbody> ();
        // Reset the score if a new game
        health = (int)healthBar.maxValue;
    }

    void Update()
    {

		//set text on screen to score + score
		healthBar.value = health;

		//Trying to get bar to follow player
		/*//If user press left or right keys, moves at speed of 10f, 0 for y as we don't want to move that way.
		float moveHorizontal = Input.GetAxis("Horizontal");
		Vector3 move = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		healthBarBody.velocity = move * barSpeed;*/

    }
}