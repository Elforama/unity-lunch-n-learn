using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class CollisionSound : MonoBehaviour {

	public AudioClip mCollisionSound;
	private AudioSource mAudioSource;

	void Start() {
		mAudioSource = GetComponent<AudioSource>();
		mAudioSource.clip = mCollisionSound;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.relativeVelocity.magnitude > 2) {
			mAudioSource.volume = collision.relativeVelocity.normalized.magnitude;
			mAudioSource.Play();
		}
	}
}
