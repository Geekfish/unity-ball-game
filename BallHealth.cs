using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public float maxFallDistance = -10F;
	public AudioClip gameOverSound;
	private bool isRestarting = false;
	
	public void Update () {
		if (this.transform.position.y <= this.maxFallDistance && !this.isRestarting) {
			this.RestartLevel();
		}
	}
	
	public void RestartLevel () {
		this.isRestarting = true;
		this.audio.clip = this.gameOverSound;
		this.audio.pitch = 1F;
		StartCoroutine(this.WaitForClipEnd(this.audio.clip.length));
		this.audio.Play ();
	}

	private IEnumerator WaitForClipEnd(float clip_length) {
		yield return new WaitForSeconds(clip_length);
		Application.LoadLevel("Level01");
	}
	 
}
