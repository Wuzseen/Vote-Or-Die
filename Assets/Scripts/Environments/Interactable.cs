using UnityEngine;
using System.Collections;

public abstract class Interactable : IVotable {
	public abstract string[] VoteChoices();
	public abstract void CallVote();
}
