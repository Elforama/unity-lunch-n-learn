using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeLimit : MonoBehaviour {

	public float lifeTime = 60;

	void Start()
	{
		StartCoroutine("LifeTimer");
	}

	IEnumerator LifeTimer()
	{
		yield return new WaitForSeconds(lifeTime);
		Destroy(this);
	}
}
