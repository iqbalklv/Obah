using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Background : MonoBehaviour
{
    [SerializeField] private IntVariable currentLevel = default;
    [SerializeField] private Container_Level levelList = default;

    [Header("Constant")]
    [SerializeField] private Container_Level master_currentLevel = default;
    [SerializeField] private float deltaY = 5.6f;
    [SerializeField] private FloatVariable initialY = default;
    [SerializeField] private GameObject bGContainer = default;
    [SerializeField] private GameObject backgroundPrefab = default;

    private GameObject top = default;

    private void Start()
    {
        master_currentLevel.Reset();

        int level = currentLevel.Value - 1;
        master_currentLevel.Levels.Clear();

        master_currentLevel.Levels.Add(levelList.Levels[level % levelList.Levels.Count]);

        top = Instantiate(backgroundPrefab, new Vector2(0f, initialY.Value), Quaternion.identity);
        top.transform.SetParent(bGContainer.transform);

        for (int i = 0; i < 5; i++)
        {
            SpawnVertical();
        }
    }

    public void SpawnVertical()
    {
        top = Instantiate(backgroundPrefab, new Vector2(top.transform.position.x, top.transform.position.y + deltaY), Quaternion.identity);
        top.transform.SetParent(bGContainer.transform);
    }
}