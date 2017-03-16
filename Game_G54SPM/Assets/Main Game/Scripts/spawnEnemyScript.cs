using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class spawnEnemyScript : MonoBehaviour {

    //Attached sprites in inspector
    public GameObject enemyBlue, enemyRed, enemyYellow, enemyPink, enemyGreen;
    public GameObject currentObj;
    // 1 seconds for a new enemy to spawn.
    public double timeToSpawn;
    public bool updateTimeCheck = true;
    Vector3 whereToSpawn;
	Rigidbody currentOBJget;

	// Use this for initialization
	void Start (){
        timeToSpawn = 1;
        //Unity method, calls method and repeats based on timeset
		InvokeRepeating("spawnEnemy", (float)timeToSpawn, (float)timeToSpawn);
	}

    void spawnEnemy(){
        //picks randomly where to spawn based on two values
		whereToSpawn = new Vector3(Random.Range(-7, 7), 0f, 24);
        //What object to spawn
        // Create an enemy at the 'whereToSpawn' position
		Instantiate(switchEnemySpawn(), whereToSpawn, Quaternion.identity);        
    }


    GameObject switchEnemySpawn()
    {
        //Random number to spawn random colour enemy
        int enemySwitchGen = Random.Range(0, 5);

        //Changes sprite to that colour
        //returns that as currentObj
        switch (enemySwitchGen)
        {
            case 0:
                currentObj = enemyYellow;
                return currentObj;
            case 1:
                currentObj = enemyBlue;
                return currentObj;
            case 2:
                currentObj = enemyGreen;
                return currentObj;
            case 3:
                currentObj = enemyPink;
                return currentObj;
            case 4:
               currentObj = enemyRed;
                return currentObj;
            default:
                return null;
        }
       
    }
}
