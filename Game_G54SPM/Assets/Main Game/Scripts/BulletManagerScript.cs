using UnityEngine;
using System.Collections;

//Script called everytime user fires. 

public class BulletManagerScript : MonoBehaviour {

    public float bulletSpeed;
	public float bulletTimeSpeed;
	public bool bulletFired;
    Rigidbody bulletSprite;

	// Use this for initialization
	void Start () {
        //get bullet component
        bulletSprite = GetComponent<Rigidbody>();
        //How fast the bullet will go when the user presses fire
		bulletSprite.velocity = new Vector3(0f, 0f, bulletSpeed);
		//Make the bullet actually appear on screen as it's wrong way.
		bulletSprite.rotation = Quaternion.Euler(90f, 0.0f, 0.0f);

	}

    //unity method, if invsibale (OFF SCREEN) 
    void OnBecameInvisible() {
        // Destroy the bullet
        Destroy(gameObject);
    } 
}