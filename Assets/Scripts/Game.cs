using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public static Game Instance;
	public delegate void GameProcess();
	public static event GameProcess OnRoundEnd;
	public int numOfPlayers;
	public PhotonView photonView;

	void Awake() {
		print ("Game created");
		Instance = this;
		photonView = this.GetComponent<PhotonView>();
		PhotonNetwork.Instantiate("Voter",Vector3.zero,Quaternion.identity,0);
	}

	public void NewGame() {
	}

	[RPC]
	public void NewPlayer() {
		numOfPlayers++;
		print (numOfPlayers);
	}
}
