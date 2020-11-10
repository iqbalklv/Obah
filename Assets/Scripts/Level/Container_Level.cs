using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableLibrary/Container Level")]
public class Container_Level : ScriptableObject
{
    [SerializeField] private List<Level> levels = new List<Level>();
    public List<Level> Levels
    {
        get { return levels; }
    }

    public void Reset()
    {
        foreach(Level level in levels)
        {
            level.Reset();
        }
    }
}
