using UnityEngine;
using System.Collections;

public class Randomization : MonoBehaviour {
	public TextAsset randomGoals;
	private string[] goals;

	public TextAsset classes;
	private string[] randClasses;
	// Use this for initialization
	void Start () {
		goals = randomGoals.text.Split('\n');
		randClasses = classes.text.Split('\n');
	}

	public void PrintRandGoal() {
		print (goals[Random.Range(0,goals.Length)]);
	}
	
	public void PrintRandClass() {
		print (randClasses[Random.Range(0,randClasses.Length)]);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
			PrintRandGoal();
		if(Input.GetKeyDown(KeyCode.W))
			PrintRandClass();
	}
}
