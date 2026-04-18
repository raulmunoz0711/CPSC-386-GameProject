using UnityEngine;

public class BombSpawnerScript : MonoBehaviour
{
    public GameObject bomb;     // prefab to spawn
    public float spawnRate = 2f;
    private float timer = 0f;

    public float heightOffset = 3.5f;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnBomb();
            timer = 0f;
        }
    }

    void SpawnBomb()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(
            bomb, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}