using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;
    public int minValue;
    public int maxValue;
    public int randomNum;
    public Button gameButton;
    private bool isGameWon = false;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }
    private void ResetGame()
    {
        if (isGameWon)
        {
            gameLabel.text = "You won! Guess the Number between " + minValue +" and " + (maxValue-1) ;
            isGameWon=false;
        }
        else
        {
            gameLabel.text = "Guess the Number between " + minValue +" and " + (maxValue-1) ;

        }
        userInput.text = "";
        randomNum = GetRandomNumber(minValue,maxValue);
        

    }

    private int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min,max);
        return random;


    }
    public void OnButtonClick()
    {
        string userInputValue = userInput.text;

        if (userInputValue != "")
        {
            int answer = int.Parse(userInputValue);
        //Code Block
            if (answer == randomNum)
            {
                gameLabel.text = "Correct! You won";
                // gameButton.interactable = false;
                isGameWon = true;
                ResetGame();
                Debug.Log("You won");
            }
            else if (answer > randomNum)
            {
                gameLabel.text = "Try Lower!";
                Debug.Log("try Lower!");
            }
            else
            {
                gameLabel.text = "Try Higher!";
                Debug.Log("Try Higher!");
            }

        }
        else
        {
            Debug.Log("Please enter a number");
        }

    }
}
