using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_Player : MonoBehaviour
{
    private float xScale;
    public IntVariable PlayerDirection;
    public IntVariable CurrentScore;
    public IntVariable LevelMaxScore;

    public IntList PathList;

    public GameEvent PlayerDeath;
    public GameEvent PlayerWin;
    public GameEvent ScoreGained;


    private void Awake()
    {
        CurrentScore.Value = 0;

        xScale = this.transform.localScale.x;

        if(xScale > 0)
        {
            PlayerDirection.Value = 1;
        }
    }

    public void ChangeDirection()
    {
        this.transform.localScale = new Vector3(xScale * PlayerDirection.Value, this.transform.localScale.y, this.transform.localScale.z);
    }

    public void CheckPosition()
    {
        if(PlayerDirection.Value == PathList.Value[0])
        {
            CurrentScore.Value++;
            ScoreGained.Raise();

            if(CurrentScore.Value >= LevelMaxScore.Value)
            {
                PlayerWin.Raise();
            }
        }
        else
        {
            Die();
        }

        PathList.Value.RemoveAt(0);
    }

    public void Die()
    {
        PlayerDeath.Raise();
        this.gameObject.SetActive(false);
    }
}
