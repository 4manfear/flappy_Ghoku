
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        score.coins = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
