using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // If you click on Play in Main Menu, starts the game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // If you click on Exit in the game, closes the game
    public void ExitGame()
    {
        Application.Quit();
    }

    // If you click on Back To Main Menu, you go back to main menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
