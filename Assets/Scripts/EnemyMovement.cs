using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// EnemyMovement handles all of the movement specifc state and behaviour for the enemy.
/// </summary>
public class EnemyMovement : MonoBehaviour {

    // enemyAcceleration indicates how fast the enemy accelerates
    [SerializeField]
    private float enemyAcceleration = 5000f;

    // local references
    private Rigidbody2D ourRigidbody;

    void Start() {
        // populate ourRigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    public void MoveEnemy(Vector2 direction) {
        //C alculate our force to add
        Vector2 forceToAdd = direction * enemyAcceleration * Time.deltaTime;
        ourRigidbody.AddForce(forceToAdd);
    }
}
