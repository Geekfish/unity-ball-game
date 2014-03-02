using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public Transform coinEffect;
	public int value = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter(Collider collider) {
		if (collider.tag == "Player") {
			GameMaster.currentScore += this.value;
			object effect = Instantiate(
				this.coinEffect,
			    this.transform.position,
			    this.transform.rotation
			);
			Destroy((effect as Transform).gameObject, 3);
			Destroy(gameObject);
		}
	}
}
