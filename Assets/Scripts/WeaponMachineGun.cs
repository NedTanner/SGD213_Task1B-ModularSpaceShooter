using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMachineGun : WeaponBase {

    /// <summary>
    /// Shoot will spawn a new bullet, provided enough time has passed compared to our fireDelay.
    /// </summary>
    public override void Shoot() {

        float currentTime = Time.time;

        // If enough time has passed since our last shot compared to our fireDelay, fire
        if (currentTime - lastFiredTime > fireDelay) {
            // Create our bullet
            GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
            // Update our shooting state
            lastFiredTime = currentTime;
        }
    }
}
