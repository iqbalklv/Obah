using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_System_Shoot : MonoBehaviour
{
    [SerializeField] private GameObject pelor;
    [SerializeField] private Transform posisiSenjata;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pelor, posisiSenjata.position, Quaternion.identity);
        }
    }

}
