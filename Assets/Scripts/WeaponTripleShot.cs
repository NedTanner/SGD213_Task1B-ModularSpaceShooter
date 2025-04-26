using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTripleShot : WeaponBase {

    /// <summary>
    /// Shoot action will spawn three bullets instead of one
    /// </summary>
    public override void Shoot() {

        float currentTime = Time.time;

        // If enough time has passed since our last shot compared to our fireDelay, spawn our bullet
        if (currentTime - lastFiredTime > fireDelay) {
            float x = -0.5f;

            for (int i = 0; i < 3; i++) {
                GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
                // Set bullet direction
                newBullet.GetComponent<MoveConstantly>().Direction = new Vector2(x + 0.5f * i, 0.5f);
            }

            lastFiredTime = currentTime;
        }
    }
}
