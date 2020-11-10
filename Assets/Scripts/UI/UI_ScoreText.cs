using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_ScoreText : MonoBehaviour
{
    public IntVariable CurrentScore;
    public IntVariable LevelMaxScore;
    public TextMeshProUGUI tmp;

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        tmp.text = CurrentScore.Value + " / " + LevelMaxScore.Value;
    }
}
