using UnityEngine;
using System.Collections;

public class PhotonSetup : MonoBehaviour {
	void Start () {
		PhotonNetwork.ConnectUsingSettings("1.0");
	}
	
	void OnReceivedRoomListUpdate() {
		PhotonNetwork.JoinOrCreateRoom("TestRoom",new RoomOptions(),null);
	}

	void OnCreatedRoom() {
		PhotonNetwork.InstantiateSceneObject("Game",Vector3.zero,Quaternion.identity,0,null);
	}

	void OnJoinedRoom() {
		PhotonNetwork.Instantiate("Voter",Vector3.zero,Quaternion.identity,0);
	}
}
