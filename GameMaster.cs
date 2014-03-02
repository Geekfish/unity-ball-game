using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public static int currentScore = 0;
	public float offsetY = 40F;
	public float sizeX = 80F;
	public float sizeY = 25F;

	// Use this for initialization
	void Start () {
		GameMaster.currentScore = 0;
	}
	
	public void OnGUI () {
		Rect box_rect = new Rect (
			(Screen.width / 2F) -  (this.sizeX / 2F),
			this.offsetY, this.sizeX, this.sizeY
		);
		GUI.Box (box_rect, string.Format ("Score: {0}",
		                                  GameMaster.currentScore));
	}
}
