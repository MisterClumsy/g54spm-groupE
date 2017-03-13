using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColourChoiceManagerScript : MonoBehaviour {

    //player score
    public static string shootColour;
    //what its attached to
    Text colourSwitchText;
    //rand number for colour switch generator
    private int rand;
    public string randColour; //the colour selected
    public float delay; //how long the game should wait before new selection
    public float nextTimeUsable; //when can we use this function again?

    void Awake()
    {
        // initilastion of text companent
        colourSwitchText = GetComponent<Text>();
    }

    void Update()
    {
        //set text on screen to score + score
        colourSwitchText.text = "Shoot: " + colourSwitcher();
    }

    //Switches colour text on screen method
    public string colourSwitcher()
    {
       
        // if time has elapsed greater than set
        if (Time.time > nextTimeUsable)
        {   
            //get new delay time between 5 - 20 seconds
            delay = Random.Range(4, 19) + 1;
            //sets the next usuable to the delay in time
            nextTimeUsable = Time.time + delay;
            //random number for each possible colour
            rand = Random.Range(0, 5);
            switch (rand)
            {
                    
                case 0:
                    randColour = "yellow"; //set text to that string
                    colourSwitchText.color = Color.yellow; //set colour of text to this
                    break;
                case 1:
                    randColour = "blue";
                    colourSwitchText.color = Color.blue;
                    break;
                case 2:
                    randColour = "green";
                    colourSwitchText.color = Color.green;
                    break;
                case 3:
					randColour = "pink";
					colourSwitchText.color = new Color(255.0f / 255.0f, 47.0f / 255.0f, 255.0f / 255.0f);
                    break;
                case 4:
					randColour = "red";
						colourSwitchText.color = Color.red;
				break;
                default:
                    break;
            }
        }
        shootColour = randColour; // need to set this to be used in other script
        return shootColour; //can access this variable from other scripts as its static

    }
}
