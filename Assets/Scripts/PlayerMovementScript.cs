using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour
{
    // Set to public to make addition of power-ups easier
    public float horizontalAcceleration = 5000f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * horizontalAcceleration * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }
}
