using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DeathMenu : MonoBehaviour
{

    public void Restart()
    {
        FindObjectOfType<Manager_Level>().Lose();
    }
   
}
