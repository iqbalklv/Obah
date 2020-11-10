 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_System_Shoot : MonoBehaviour
{
    [SerializeField] private GameObject peluru1;
    [SerializeField] private GameObject peluru2;
    [SerializeField] private Transform posisiSenjata1;
    [SerializeField] private Transform posisiSenjata2;



    private void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(peluru1, posisiSenjata1.position, Quaternion.identity);
                Instantiate(peluru2, posisiSenjata2.position, Quaternion.identity);
        }
        
    }
     
}
