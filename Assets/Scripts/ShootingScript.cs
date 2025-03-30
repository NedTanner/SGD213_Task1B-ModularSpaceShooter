using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;

    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;

    private float bulletOffset = 2f;

    void Start()
    {
        // Calculate bullet position
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of player size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Half of bullet size
    }

    public void Shoot()
    {
        float CurrentTime = Time.time;

        // Check if fireDelay is finished
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

            Instantiate(bullet, spawnPosition, transform.rotation);

            lastFiredTime = CurrentTime;
        }
    }
}
