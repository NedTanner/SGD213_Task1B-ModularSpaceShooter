using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        // Detects player input, calls movement function
        if (HorizontalInput != 0.0f )
        {
            playerMovementScript.HorizontalMovement(HorizontalInput);
        }

        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                Debug.Log("Requires 'ShootingScript'!");
            }
            
        }
    }
    
}
