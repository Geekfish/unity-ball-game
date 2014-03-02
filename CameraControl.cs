using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public Transform target;
	public float distance = -10F;
	public float lift = 1.5F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = target.position +
			new Vector3(0, this.lift, this.distance);
		this.transform.LookAt (this.target);
	}
}
