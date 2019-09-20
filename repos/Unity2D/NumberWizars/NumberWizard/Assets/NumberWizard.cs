using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
      {
        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("G'day mate, welcome to numba wiz-ud...");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
	}

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            Debug.Log(guess);
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            Debug.Log(guess);
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
            Debug.Log("I am a genius!");
        }
    }
}
    
   