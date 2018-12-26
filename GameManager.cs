using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 2f;
    public GameObject LevelCompleteUI;

    public void Start()
    {
        LevelCompleteUI.SetActive(false);
    }

    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", RestartDelay);
        }

    }

    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
