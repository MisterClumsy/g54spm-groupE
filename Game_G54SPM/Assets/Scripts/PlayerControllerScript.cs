using UnityEngine;
using System.Collections;

//Need this to see in inspector
[System.Serializable]
public class Boundary{
	public float MinX, MaxX;
}

public class PlayerControllerScript : MonoBehaviour {

    Rigidbody spaceShip_Component;
    public GameObject bulletLaserSprite;
	public Boundary boundary;
	public float playerSpeed;
	public float playerTilt;

	// Use this for initialization
	void Start () {
        //get spaceShip on the screen
		spaceShip_Component = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //If user press left or right keys, moves at speed of 10f, 0 for y as we don't want to move that way.
		float moveHorizontal = Input.GetAxis("Horizontal");
		Vector3 move = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		spaceShip_Component.velocity = move * playerSpeed;
			
		//Boundary for player, change values in inspector (SET TO -6 and 6)
		//We don't need Y or Z values as it's only going left / right
		spaceShip_Component.position = new Vector3(
			Mathf.Clamp (spaceShip_Component.position.x, boundary.MinX, boundary.MaxX), 
			0.0f, 
			0.0f
		);

		spaceShip_Component.rotation = Quaternion.Euler(0.0f, 0.0f, spaceShip_Component.velocity.x * playerTilt);
		/* //if user left clicks or presses space, fire bullet
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
		{
			// Creates bullet at position of flyingSaucerSprite
			Instantiate(bulletLaserSprite, transform.position, Quaternion.identity);
		}*/
	}
}
