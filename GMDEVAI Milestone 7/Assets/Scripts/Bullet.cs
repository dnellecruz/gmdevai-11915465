using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject explosion;
	
	void OnCollisionEnter(Collision col)
    {
    	GameObject e = Instantiate(explosion, this.transform.position, Quaternion.identity);
    	Destroy(e, 1.5f);

        if (col.gameObject.GetComponent<Health>())
            col.gameObject.GetComponent<Health>().TakeDamage(10);

        if (col.gameObject.GetComponent<TankAI>())
            col.gameObject.GetComponent<TankAI>().UpdateHealth();


        Destroy(this.gameObject);
    }

	void Start ()
    {
        Physics.IgnoreLayerCollision(3, 3);
    }
}
