﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public static Player localPlayer;
	public Trait trait;
	public Goal goal;
	private PhotonView photonView;
	
	// Use this for initialization
	void Awake () {
		Game.OnRoundEnd += GoalCompleted;
		Game.Instance.NewGame();
		photonView = this.GetComponent<PhotonView>();
		if(PhotonNetwork.player == photonView.owner) {
			localPlayer = this;
		}
	}

	protected void GoalCompleted() {
	}

	void OnDestroy() {
		Game.OnRoundEnd -= GoalCompleted;
	}
}
