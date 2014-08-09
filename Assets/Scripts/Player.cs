using UnityEngine;
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
		if(PhotonNetwork.player == photonView.owner) {
			localPlayer = this;
			Game.Instance.photonView.RPC("NewPlayer",PhotonTargets.All,null);
		}
	}

	protected void GoalCompleted() {
	}

	void OnDestroy() {
		Game.OnRoundEnd -= GoalCompleted;
	}
}
