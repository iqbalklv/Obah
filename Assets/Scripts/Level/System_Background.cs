using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class System_Background : MonoBehaviour
{
    [SerializeField] private Container_Level master_CurrentLevel = default;
    [SerializeField] private float deltaX = 10f;
    [SerializeField] private int countInRow = 10;
    [SerializeField] private GameObject backgroundNonSpawner = default;
    [SerializeField] private IntVariable playerDirection = default;
    [SerializeField] private float yJump = 0.75f;
    [SerializeField] private float xJump = 0.75f;
    [SerializeField] private FloatVariable initialY = default;
    [SerializeField] private IntVariable jumpCountToSpawnBG = default;
    [SerializeField] private GameEvent bottomBGDestroyed = default;

    private Level currentLevel = default;
    private float yDeath = default;

    private void Start()
    {
        yDeath = -((jumpCountToSpawnBG.Value * yJump) - initialY.Value);

        currentLevel = master_CurrentLevel.Levels[0];
        SetSprite();
        SpawnHorizontal();
    }
    
    private void SetSprite()
    {
        this.GetComponent<SpriteRenderer>().sprite = currentLevel.CurrentRepeat;
    }

    private void SpawnHorizontal()
    {
        for (int i = -1; i < 2; i+=2)
        {
            for (int j = 1; j <= countInRow; j++)
            {
                GameObject sibling = Instantiate(backgroundNonSpawner, new Vector2((deltaX * j * i) + this.transform.position.x, this.transform.position.y), Quaternion.identity);
                sibling.transform.SetParent(this.transform);


                sibling.GetComponent<SpriteRenderer>().sprite = this.GetComponent<SpriteRenderer>().sprite;
            }
        }
    }

    public void Move()
    {
        int currentDir = playerDirection.Value * -1;

        transform.Translate(currentDir * xJump, -yJump, 0f);

        if(this.transform.position.y <= yDeath)
        {
            bottomBGDestroyed.Raise();
            this.gameObject.SetActive(false);
        }
    }
}
