using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_TimerText : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public FloatVariable CurrentLevelDuration;

    private void Update()
    {
        tmp.text = "" + (int)CurrentLevelDuration.Value;
    }
}
