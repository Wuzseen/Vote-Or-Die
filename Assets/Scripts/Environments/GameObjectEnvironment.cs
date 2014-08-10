using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameObjectEnvironment : MonoBehaviour {
	public GameEnvironment env;
	private PhotonView photonView;

	public List<Transform> interactableSpawnPoints;

	public void SetEnvironment(GameEnvironment env) {
		this.env = env;
		Build ();

	}
	// Use this for initialization
	void Awake () {
		this.photonView = this.GetComponent<PhotonView>();
	}

	void Build() {
		foreach(Interactable i in env.interactableObjects) {
			// stuff
		}
	}
}
