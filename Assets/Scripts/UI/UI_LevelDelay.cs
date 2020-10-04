using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_LevelDelay : MonoBehaviour
{
    public TextMeshProUGUI DelayText;
    public FloatVariable LevelDelay;

    private void Start()
    {
            DelayText.gameObject.SetActive(true);
    }

    private void Update()
    {
        DelayText.text = "" + ((int)LevelDelay.Value + 1);

        if(DelayText.fontSize > 150)
        DelayText.fontSize -= Time.deltaTime * 20;

        if(LevelDelay.Value <= 0)
        {
            DelayText.gameObject.SetActive(false);
        }
    }
}
