using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_StairMovement : MonoBehaviour
{
    public IntVariable PlayerDirection;

    public void Move()
    {
        this.transform.Translate(-PlayerDirection.Value, -1f, 0f);
    }
}
