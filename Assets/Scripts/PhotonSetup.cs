using UnityEngine;
using System.Collections;

public class PhotonSetup : MonoBehaviour {
	public static PhotonSetup Instance;
	void Start () {
		PhotonNetwork.ConnectUsingSettings("1.0");
	}
	
	void OnReceivedRoomListUpdate() {
		PhotonNetwork.JoinOrCreateRoom("TestRoom",new RoomOptions(),null);
	}

	void OnCreatedRoom() {
		print ("Creating Room");
		PhotonNetwork.InstantiateSceneObject("Game",Vector3.zero,Quaternion.identity,0,null);
	}

	void OnJoinedRoom() {
		print ("Joined Room");
		PhotonNetwork.Instantiate("Voter",Vector3.zero,Quaternion.identity,0);
	}
}
