using UnityEngine;
using System.Collections;

interface IVotable {
	string[] VoteChoices();
	void CallVote();
}
