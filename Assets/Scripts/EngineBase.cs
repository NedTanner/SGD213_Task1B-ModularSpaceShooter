using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineBase : MonoBehaviour
{
    // acceleration indicates how fast the enemy accelerates
    [SerializeField]
    private float acceleration = 5000f;

    // local references
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        // populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Accelerate takes a direction as a parameter, and applies a force in this provided direction
    /// to ourRigidbody, based on the acceleration variables and the delta time.
    /// </summary>
    public void Accelerate(Vector2 direction)
    {
        if (direction.magnitude != 0)
        {
            Vector2 forceToAdd = direction * acceleration * Time.deltaTime;
            ourRigidbody.AddForce(forceToAdd);
        }
    }
}
