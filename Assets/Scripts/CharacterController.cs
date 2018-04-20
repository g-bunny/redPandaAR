using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

	public int paceCycles = 5;

	Rigidbody rigidB;

	float moveZ = -0.15f;
	int numCyclesWalked = 0;
	float scaleZ = 1f;


	// Use this for initialization
	void Start () {
		rigidB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Pace();

	}

	void Pace(){
		rigidB.velocity = new Vector3 (0f, 0f, moveZ);
	}

	void CountCycles(){
		numCyclesWalked++;
		if (numCyclesWalked % paceCycles == 0) {
			moveZ *= -1;
			scaleZ *= -1;
			rigidB.transform.localScale = new Vector3(1f, 1f, scaleZ);
		}
	}
}
