using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // For the Continue button
    public void ContinueGame()
    {
        // Default to soccer game
        SceneManager.LoadScene("SampleScene");  // This is the soccer game, but renaming things in Unity causes weird issues
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
