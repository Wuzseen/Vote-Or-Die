using UnityEngine;
using System.Collections;

public abstract class Interactable : MonoBehaviour, IVotable {
	public abstract string[] VoteChoices();
}
