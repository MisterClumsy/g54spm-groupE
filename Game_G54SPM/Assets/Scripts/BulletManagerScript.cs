using UnityEngine;
using System.Collections;

//Script called everytime user fires. 

public class BulletManagerScript : MonoBehaviour {

    public float bulletSpeed;
    Rigidbody bulletSprite;

	// Use this for initialization
	void Start () {
        //get bullet component
        bulletSprite = GetComponent<Rigidbody>();
        //How fast the bullet will go when the user presses fire
		bulletSprite.velocity = new Vector3(0f, 0f, bulletSpeed);
		bulletSprite.rotation = Quaternion.Euler(90f, 0.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //unity method, if invsibale (OFF SCREEN) 
    void OnBecameInvisible() {
        // Destroy the bullet (this is what ever script is attached too)
        Destroy(gameObject);
    } 

}
