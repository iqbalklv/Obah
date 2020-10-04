using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_LevelText : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public IntVariable CurrentLevel;

    private void Start()
    {
        tmp.text = "Level = " + CurrentLevel.Value;
    }
}
