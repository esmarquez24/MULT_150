using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEditor.XR;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    private bool isRunning = false;
    private float elapsedTime = 0;

    private void Start()
    {
        elapsedTime = 0;
        isRunning = true;
        isGameOver = false;
    }
    private void GameOver()
    {
        isRunning = false;
        isGameOver = true;
        Debug.Log("Made it to Game Over");
    }
    // Update is called once per frame
    void Update()
    {
       if (isRunning)
       {
            elapsedTime = elapsedTime + Time.deltaTime;
       }
        // if all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;
        if (isGameOver == true)
        {
            GameOver();
        }
    }

    private void OnGUI()
    {
        if (!isRunning)
        {
            string message;
            if (isGameOver)
            {
                message = "Play Again?";
            }
            else
            {
                message = "Ready?";
            }

            Rect startButton = new Rect((Screen.width / 2) - 120, Screen.height / 2, 240, 30);
            if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
            {
                //start the game if the user clicks to play
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }
        }
        // If the player finished the game, show the final time
        if (isGameOver)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
        }
        else if (isRunning)
        {
            // If the game is running, show the current time
            GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Time Is");
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 20, 30), ((int)elapsedTime).ToString());
        }
    }

}
