using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager_Level : MonoBehaviour
{
    public IntVariable CurrentLevel;
    public FloatVariable LevelDelay;
    public FloatVariable LevelDurationAddition;
    public IntVariable LevelMaxScore;

    public GameEvent TimeRunOut;

    public FloatVariable CurrentLevelDuration;

    public DeathMenu DeathMenuUI;

    

    private void Awake()
    {
        LevelDelay.Value = 5f;
    }

    private void Start()
    {
        SetLevelDuration();
        SetLevelMaxScore();
    }

    private void Update()
    {
        if (LevelDelay.Value <= 0)
        {
            if (!hasWin)
            {
                CurrentLevelDuration.Value -= Time.deltaTime;

                if (CurrentLevelDuration.Value <= 0)
                {
                    TimeRunOut.Raise();
                }
            }
        }
        else
        {
            LevelDelay.Value -= Time.deltaTime;
        }
    }

    public void SetLevelDuration()
    {
        CurrentLevelDuration.Value = 30f;

        if (CurrentLevel.Value < 1)
        {
            CurrentLevel.Value = 1;
        }

        if (CurrentLevel.Value == 1)
        {
            LevelDurationAddition.Value = 0f;
        }
        else
        {
            LevelDurationAddition.Value = CurrentLevel.Value * 1.5f;
        }

        CurrentLevelDuration.Value -= LevelDurationAddition.Value;
    }

    private void SetLevelMaxScore()
    {
        if (CurrentLevel.Value == 1)
        {
            LevelMaxScore.Value = 10;
        }
        else
        {
            LevelMaxScore.Value = 10 + (int)(CurrentLevel.Value * 2.5f);
        }
    }

    private bool hasWin = false;

    public void Win()
    {
        hasWin = true;

        CurrentLevel.Value++;
        print("Player Win!");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Lose()
    {
        DeathMenuUI.gameObject.SetActive(true);
       CurrentLevel.Value = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("Player Lose!");
    }

}
