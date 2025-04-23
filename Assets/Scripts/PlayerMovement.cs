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
        // populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    public void MovePlayer(Vector2 direction)
    {
        // a horizontalInput of 0 has no effect, as we want our ship to drift
        if (direction.magnitude != 0)
        {
            //calculate our force to add
            Vector2 forceToAdd = direction * horizontalPlayerAcceleration * Time.deltaTime;
            // apply forceToAdd to ourRigidbody
            ourRigidbody.AddForce(forceToAdd);
        }
    }
}
