using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	public delegate void GameProcess();
	public static event GameProcess OnRoundEnd;
	public int numOfPlayers;


	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("1.0");
	}

	void OnReceivedRoomListUpdate() {
		PhotonNetwork.JoinOrCreateRoom("TestRoom",new RoomOptions(),null);
	}

	void OnJoinedRoom() {
		PhotonNetwork.Instantiate("Player",Vector3.zero,Quaternion.identity,0);
	}
}
