using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NV_PlayerAnim : MonoBehaviour
{
    public Animator animator;
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("Speed", Mathf.Abs(1f));
        }
        else
            animator.SetFloat("Speed", Mathf.Abs(0f));
    }
}
