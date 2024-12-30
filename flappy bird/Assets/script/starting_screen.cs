using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class starting_screen : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
   public void quittingGame()
    {
        Application.Quit();
    }
}
