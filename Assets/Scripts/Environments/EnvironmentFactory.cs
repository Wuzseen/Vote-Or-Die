using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnvironmentFactory : MonoBehaviour {
	public static int NumOfEnvironments = 5;
	public static GameEnvironment CreateEnvironment(RoomTypes roomType) {
		GameObject go = null;
		GameObjectEnvironment goe = null;
		GameEnvironment ret = null;
		if(roomType == RoomTypes.Disco) {
			// return a disco environment
			go = (GameObject)PhotonNetwork.InstantiateSceneObject("discoRoom",Vector3.zero,Quaternion.identity,3,null);
			ret = null; // <---- disco environment constructor
		} else if (roomType == RoomTypes.NarniaPort) {

		} else {
			go = (GameObject)PhotonNetwork.InstantiateSceneObject("emptyRoom",Vector3.zero,Quaternion.identity,3,null);
			ret = null;
		}
		goe = go.GetComponent<GameObjectEnvironment>();
		goe.SetEnvironment(ret);
		return ret;
	}

	public GameObject discoRoom, emptyRoom, narniaRoom;
}
