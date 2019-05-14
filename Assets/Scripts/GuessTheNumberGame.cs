using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour
{   
    public InputField input;
    public Text infotext;

    private int guessNumber;
    private int usersGuess;
    // Start is called before the first frame update
    void Start()
    {
        guessNumber = Random.Range(0, 100);
    }

    public void CheckGuess() {
        usersGuess = int.Parse(input.text);

        if(usersGuess == guessNumber) {
            infotext.text = "You guessed the number! A Wizzard!";
        } else if (usersGuess > guessNumber) {
            infotext.text = "Try smaller number!";
        } else if (usersGuess < guessNumber) {
            infotext.text = "Try GREATER number!";
        }
    }
}

