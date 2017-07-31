using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print("hit " + other.name + "!");

        EnemyStats stats;

        if (stats = other.GetComponent<EnemyStats>())
        {
            stats.ChangeHealth(-5);
        }

        Destroy(gameObject);
    }
}
