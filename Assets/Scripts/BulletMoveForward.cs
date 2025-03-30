using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f;

    private float initialVelocity = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = Vector2.up * initialVelocity;
    }

    void Update()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;

        rb.AddForce(ForceToAdd);
    }
}
