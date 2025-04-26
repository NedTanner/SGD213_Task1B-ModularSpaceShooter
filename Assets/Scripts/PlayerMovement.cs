using UnityEngine;
using System.Collections;

/// <summary>
/// PlayerMovementScript handles all of the movement specifc state and behaviour for the player.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // horizontalPlayerSpeed indicates how fast we accelerate Horizontally
    [SerializeField]
    private float horizontalPlayerAcceleration = 5000f;

    // local references
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    public void MovePlayer(Vector2 direction)
    {
        // A horizontalInput of 0 has no effect
        if (direction.magnitude != 0)
        {
            //Calculate our force to add
            Vector2 forceToAdd = direction * horizontalPlayerAcceleration * Time.deltaTime;
            ourRigidbody.AddForce(forceToAdd);
        }
    }
}
