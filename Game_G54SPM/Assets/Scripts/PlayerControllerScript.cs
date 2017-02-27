using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {

    Rigidbody2D flyingSaucer;
    public GameObject bulletLaserSprite;

	// Use this for initialization
	void Start () {
        //get flyingSaucer on the screen
        flyingSaucer = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        //If user press left or right keys, moves at speed of 250f, 0 for y as we don't want to move that way.
        flyingSaucer.velocity = new Vector2(Input.GetAxis("Horizontal") * 10f, 0f);

        //if user left clicks or presses space, fire bullet
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            // Creates bullet at position of flyingSaucerSprite
            Instantiate(bulletLaserSprite, transform.position, Quaternion.identity);
        }

        /*Vector3 position = transform.position;
        float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = GameObject.Find ("Canvas").GetComponent<Canvas> ().worldCamera.orthographicSize * screenRatio -100;
        // X axis
        if (position.x + 1.6f >= widthOrtho)
        {
            //transform.position = new Vector2(widthOrtho - 1.6f, transform.position.y);
			transform.position = new Vector3 (widthOrtho + 1.6f, transform.position.y, 0);
        }
        if (position.x -1.6f <= -widthOrtho)
        {
            //transform.position = new Vector2(-widthOrtho + 1.6f, transform.position.y);
			transform.position = new Vector3 (-widthOrtho + 1.6f, transform.position.y, 0);
        }*/
        
	}
}
