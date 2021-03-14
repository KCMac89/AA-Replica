using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    
    

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
       
        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        PlayerPrefs.SetInt("score", Score.PinCount);

       // PlayerPrefs.Save();
        
        Debug.Log("END GAME");
       
        // Credits();
    }

    

  

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
