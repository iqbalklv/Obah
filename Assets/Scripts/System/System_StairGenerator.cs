using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class System_StairGenerator : MonoBehaviour
{
    public GameObject StairPrefab;
    public Vector2Variable StairPoint;
    public IntVariable StairsCount;
    public GameEvent SpawnStairSet;
    public IntList PathList;
    
    void Start()
    {
        GameObject currentStair;

        for (int i = 0; i < StairsCount.Value; i++)
        {
            NextStairPoint();
            currentStair = Instantiate(StairPrefab, StairPoint.Value, Quaternion.identity);
            currentStair.transform.SetParent(this.transform);
        }
       
    }

    private void NextStairPoint()
    {
        switch (Random.Range(0, 2))
        {
            case 0:
                StairPoint.Value.x += 1;
                PathList.Value.Add(1);
                break;
            case 1:
                StairPoint.Value.x -= 1;
                PathList.Value.Add(-1);
                break;
        }

        StairPoint.Value.y += 1;
    }

    public void CheckStairSetPosition()
    {
        if (this.transform.position.y <= StairsCount.Value * -2f)
        {
            SpawnStairSet.Raise();
            Destroy(this.gameObject);
        }
    }
    
}
