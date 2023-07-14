using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public GameObject bullet;
    public GameObject turret;
    float fireRate;

    void Update()
    {
        if (fireRate > 0)
            fireRate -= Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && fireRate <= 0)
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject b = Instantiate(bullet, turret.transform.position, turret.transform.rotation);
        b.GetComponent<Rigidbody>().AddForce(turret.transform.forward * 500);
        fireRate = 0.5f;
    }
}
