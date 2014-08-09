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
		photonView = this.GetComponent<PhotonView>();
		if(photonView.isMine) {
			localPlayer = this;
			Game.Instance.NewPlayer();
		}
	}

	protected void GoalCompleted() {
	}

	void OnDestroy() {
		Game.OnRoundEnd -= GoalCompleted;
	}
}
