using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private BoolVariable hasWin = default;

    public void Restart()
    {
        FindObjectOfType<Manager_Level>().Lose();
    }

    private void OnEnable()
    {
        hasWin.Value = true;
        Time.timeScale = 0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }
}
