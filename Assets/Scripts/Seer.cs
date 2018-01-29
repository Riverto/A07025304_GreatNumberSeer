using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Seer : MonoBehaviour {
    //Declaration of variables used by the game
    private int min;
    private int max;
    private int guess;

    //variable to set attempts within unity
    [SerializeField] int attempts;

    //variable from which the guess textbox gets its text
    [SerializeField] Text guessLabel;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    private void StartGame()
    {
        min = 1;
        max = 1001;
        guess = UnityEngine.Random.Range(min, max);
        ShowGuess();
    }

    private void NextGuess()
    {
        if (attempts == 0)//If no attempts left
        {
            //Load Seer lose screen (player win screen)
            SceneManager.LoadScene("Lose");
        }
        else
        {
            //else guess a number
            guess = UnityEngine.Random.Range(min, max);
            attempts--;
            ShowGuess();
        }
    }

    private void ShowGuess()
    {
        //sets our guess to the textbox
        guessLabel.text = "Is your number " + guess + "?";
    }

    //When the number is higher than the guess
    public void isHigher()
    {
        Debug.Log("Higher");
        //the minimum guess becomes our guess+1
        min = guess +1;
        NextGuess();
    }
    
    //When the number is lower than the guess
    public void isLower()
    {
        Debug.Log("Lower");
        //the maximum guess becomes our guess
        max = guess;
        NextGuess();
    }

    //When we guess correctly
    public void Correct()
    {
        Debug.Log("Correct");
        Debug.Log("I had " + attempts + "left");
        //We load the Seer win screen (Player lose screen)
        SceneManager.LoadScene("Win");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
