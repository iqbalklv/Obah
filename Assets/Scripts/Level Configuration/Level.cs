using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableLibrary/Level")]
public class Level : ScriptableObject
{
    [SerializeField] private List<Sprite> initial = new List<Sprite>();

    public Sprite Initial
    {
        get { return initial[Random.Range(0, initial.Count)]; }
    }

    [SerializeField] private List<Sprite> repeating = new List<Sprite>();

    private int currentIndex = 0;
    public Sprite CurrentRepeat
    {
        get {
            Sprite result;

            currentIndex %= repeating.Count;

            result = repeating[currentIndex];

            currentIndex++;
            return result;
        }
    }

    public void Reset()
    {
        currentIndex = 0;
    }
}