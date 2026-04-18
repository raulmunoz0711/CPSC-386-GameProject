using UnityEngine;

public class BombMovementScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 8f;

    // Update is called once per frame
    void Update()
    {
        //Changing bomb position to move left across the scene at the specified speed and making sure
        //it is speed per second and not frame per second with deltaTime.
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Deletes bomb after it moves off screen
        if (transform.position.x < -25f)
        {
            //Console visual of bomb being deleted
            Debug.Log("Bomb Deleted");
            Destroy(gameObject);
        }
    }
}