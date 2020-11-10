using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        ResetVariables();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    [Header("Reset")]
    [SerializeField] private IntVariable currentLevel = default;
    [SerializeField] private Container_Level levelList = default;
    [SerializeField] private BoolVariable hasWin = default;

    public void ResetVariables()
    {
        hasWin.Value = false;
        Time.timeScale = 1f;
        currentLevel.Value = 1;
        levelList.Reset();
    }
}

