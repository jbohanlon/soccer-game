using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
    // If you click Yes in the quit menu, go back to the main menu
    public void QuitGame()
    {
        SceneManager.LoadScene("MenuScene");    // Go back to the main menu
    }

    // If you click No in the quit menu, close the quit menu and continue the game
    public void HideQuitMenu()
    {
        this.gameObject.SetActive(false);
    }
}
