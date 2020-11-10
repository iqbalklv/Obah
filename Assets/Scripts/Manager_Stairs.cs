using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Stairs : MonoBehaviour
{
    public Vector2Variable StairPoint;
    public IntVariable StairCount;
    public GameObject StairSet;
    public IntVariable PlayerDirection;
    public IntList PathList;

    void Start()
    {
        ResetLastStair();

        for (int i = 0; i <= 5; i++)
        {
            SpawnInitialStairs(StairCount.Value * i);
        }
    }

    private void ResetLastStair()
    {
        StairPoint.Value = new Vector2(0f, 0f);
        PathList.Value.RemoveRange(0, PathList.Value.Count);
    }

    private void SpawnInitialStairs(float y)
    {
        Instantiate(StairSet, new Vector3(0f, y, 0f), Quaternion.identity);
    }

    public void SpawnStairs()
    {
        Instantiate(StairSet, new Vector3(0f, StairCount.Value * 4, 0f), Quaternion.identity);
    }

    public void AdjustLastStairPoint()
    {
        StairPoint.Value.x -= PlayerDirection.Value;
        StairPoint.Value.y--;
    }
}
