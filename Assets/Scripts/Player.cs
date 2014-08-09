using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public Trait trait;
	public Goal goal;
	
	// Use this for initialization
	void Awake () {
		Game.OnRoundEnd += GoalCompleted;
		print ("Hello");
	}

	protected void GoalCompleted() {
		print ("Hello");
	}

	void OnDestroy() {
		Game.OnRoundEnd -= GoalCompleted;
	}
}
