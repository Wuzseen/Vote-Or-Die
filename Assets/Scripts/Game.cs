using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public static Game Instance;
	public delegate void GameProcess();
	public static event GameProcess OnRoundEnd;
	public int numOfPlayers;
	public PhotonView photonView;

	void Awake() {
		Instance = this;
		photonView = this.GetComponent<PhotonView>();
	}

	public void NewGame() {
	}

	[RPC]
	public void NewPlayer() {
		numOfPlayers++;
		print (numOfPlayers);
	}
}
