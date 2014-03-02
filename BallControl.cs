using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallControl : MonoBehaviour {
	public int rotationSpeed = 100;
	public int jumpHeight = 8;
	public AudioClip[] hitSounds;
	private float distToGround;

	public void Start() {
		this.distToGround = this.collider.bounds.extents.y;
	}

	public bool IsGrounded() {
		return Physics.Raycast (this.transform.position, -Vector3.up, distToGround + 0.1F);
	}
	
	// Update is called once per frame
	void Update () {
		// Handle ball horizontal rotation
		float rotation = Input.GetAxis ("Horizontal") * this.rotationSpeed;
		rotation *= Time.deltaTime;
		this.rigidbody.AddRelativeTorque(Vector3.back * rotation);

		if (Input.GetKeyDown(KeyCode.W) && this.IsGrounded()) {
			this.rigidbody.AddForce (Vector3.up * this.jumpHeight,
			                        ForceMode.VelocityChange);
		}
	}

	public void OnCollisionEnter(Collision collision) {
		this.audio.clip = this.hitSounds [Random.Range (0, this.hitSounds.Length)];
		this.audio.pitch = Random.Range (0.9F, 1.1F);
		this.audio.Play ();
	}
}
