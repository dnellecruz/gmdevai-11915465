using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        health = Mathf.Max(health, 0);

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
