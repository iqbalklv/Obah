using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Manager_Level : MonoBehaviour
{
    [SerializeField] Container_Level levelList = default;


    public IntVariable CurrentLevel;
    public FloatVariable LevelDelay;
    public FloatVariable LevelDurationAddition;
    public IntVariable LevelMaxScore;

    public GameEvent TimeRunOut;

    public FloatVariable CurrentLevelDuration;

    public AnimationClip Player_Win = default;

    private void Awake()
    {
        LevelDelay.Value = 3f;
        hasWin.Value = false;
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
            if (!hasWin.Value)
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
        CurrentLevelDuration.Value = 20f;

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

        CurrentLevelDuration.Value += LevelDurationAddition.Value;
    }


    private int LevelMaxScore_Level1 = 20;

    private void SetLevelMaxScore()
    {
        if (CurrentLevel.Value == 1)
        {
            LevelMaxScore.Value = LevelMaxScore_Level1;
        }
        else
        {
            LevelMaxScore.Value = LevelMaxScore_Level1 + (int)(CurrentLevel.Value * 2.5f);
        }
    }

    [SerializeField] private BoolVariable hasWin = default;

    public void Win()
    {
        hasWin.Value = true;

        CurrentLevel.Value++;

        Invoke("NextLevel", Player_Win != null ? Player_Win.length + .5f : 0f);
    }

    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Lose()
    {
        ResetVariables();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetVariables()
    {
        Time.timeScale = 1f;
        CurrentLevel.Value = 1;
        levelList.Reset();
    }
}
