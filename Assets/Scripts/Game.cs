using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public static Game Instance;
	public delegate void GameProcess();
	public static event GameProcess OnRoundEnd;
	public int numOfPlayers;
	private PhotonView photonView;

	void Awake() {
		Instance = this;
		photonView = this.GetComponent<PhotonView>();
	}

	public void NewGame() {
		print ("wuthup");
	}
}
