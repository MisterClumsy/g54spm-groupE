using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyManagerScript : MonoBehaviour
{

    public float enemySpeed;
    Rigidbody enemy;
    public static string getColour;
    private int highscore;
	public float tumble;

    // Use this for initialization
    void Start()
    {
		
        //Set bullet speed
        enemySpeed = -5f;
        //get enemy component
        enemy = GetComponent<Rigidbody>();
        //Set speed in which enemy falls
		enemy.velocity = new Vector3(0f, 0f, enemySpeed);
        //Rotate so it looks cool when moving down
		enemy.angularVelocity =  Random.insideUnitSphere * 2;
		enemy.rotation = Quaternion.Euler(90, 0, 0);

    }

	void OnTriggerEnter (Collider objCollider)
	{
        // Name of the object that collided with the enemy
		string nameOfObject = objCollider.gameObject.name;
        //Has enemy hit bullet?

		if (nameOfObject == "BulletLaserSprite(Clone)")
        {
            //call addScore method to see if score can update or health is lost
            addScore();
            //destroy enemy and bullet           
			Destroy(objCollider.gameObject);
			Destroy(gameObject);
        }
    }

	void OnBecameInvisible() {
		// Destroy the bullet
		Destroy(gameObject);
	} 

    //method do add score based on enemies shot
    void addScore()
    {
        //gameObject is the enemy shot set to variable for comparision
        getColour = gameObject.ToString();
        switch (ColourChoiceManagerScript.shootColour)
        {
            case "yellow": //if the colour enemy the user is told to shoot is active
                if (getColour == "enemySprites_0(Clone) (UnityEngine.GameObject)")//and the user has shot the same colour enemy
                {   
                    //update score by +1
                    ScoreManagerScript.score += 1; //updates within scoreManagerScript
                }
                else    //if the user has shot wrong bullet at wrong colour
                {
                   HealthManagerScript.health -= 20;// deduct 20 from health
                   gameOver(); //Call gameOver method to check if health has reached 0
                }
                break;//break if matches the active colour but not with one shot.
            case "blue":
                if (getColour == "enemySprites_1(Clone) (UnityEngine.GameObject)")
                {
                    ScoreManagerScript.score += 1;
                }
                else
                {
                   HealthManagerScript.health -= 20;
                   gameOver();
                }
                break;
            case "pink":
                if (getColour == "enemySprites_2(Clone) (UnityEngine.GameObject)")
                {
                    ScoreManagerScript.score += 1;
                }
                else
                {
                   HealthManagerScript.health -= 20;
                   gameOver();
                }
                break;
            case "green":
                if (getColour == "enemySprites_3(Clone) (UnityEngine.GameObject)")
                {
                    ScoreManagerScript.score += 1;
                }
                else
                {
                    HealthManagerScript.health -= 20;
                    gameOver();
                }
                break;
            case "red":
                if (getColour == "enemySprites_4(Clone) (UnityEngine.GameObject)")
                {
                    ScoreManagerScript.score += 1;
                }
                else
                {
                    HealthManagerScript.health -= 20;
                    gameOver();
                }
                break;
            default:
                break;
        }
    }

    //method to see if health has reached 0
   void gameOver()
    {
        //checks if health is 0
        if (HealthManagerScript.health == 0)
        {
           /* //sets current score to variable from other script
            GamValSpace.currentScoreGetterSpace = ScoreManagerScript.score;
            //set highscore to equal value of current highscore
            highscore = PlayerPrefs.GetInt("HIGH_SCORE_SPACE", 0);

            // if the score the user got it > than one that exists update
            if (GamValSpace.currentScoreGetterSpace > highscore)
            {
                //set high score to equal, current score usuer has go
                PlayerPrefs.SetInt("HIGH_SCORE_SPACE", ScoreManagerScript.score);
            }
            //change to game over scene
            Application.LoadLevel("gameOverSpace");*/
			Debug.Log ("YOU DEAD");
        }
    }
}
