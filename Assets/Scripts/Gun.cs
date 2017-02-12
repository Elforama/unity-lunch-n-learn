using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject bulletPrefab;
	public int bulletSpeed = 1500;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
			Rigidbody body = bullet.GetComponent<Rigidbody>();
			body.AddForce(transform.forward * bulletSpeed);
		}
	}
}
