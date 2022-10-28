using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacterMenu : MonoBehaviour
{
    public void LoadSoccerGame()
    {
        SceneManager.LoadScene("SampleScene");  // This is the soccer game, but renaming things in Unity causes weird issues
    }
    
    // TODO: Add two functions for the two other games
}
