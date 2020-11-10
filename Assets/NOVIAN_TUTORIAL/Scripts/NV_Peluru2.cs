using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_Peluru2 : MonoBehaviour
{
   
  
        //percobaan liat utub
        [SerializeField]  private float speed;

        private void Update()
        {
            transform.Translate(transform.right * speed * Time.deltaTime, 0f);
        }
    
}
