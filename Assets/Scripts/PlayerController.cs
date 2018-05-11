using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public bool turnRight = false;
	public bool turnLeft = false;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		listenForInput();
		animator.SetBool("turnLeft", turnLeft);
		//turnRight = false;
		//turnLeft = false;
	}

	void listenForInput(){
		if (Input.GetKey(KeyCode.RightArrow)){
			turnRight = true;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			turnLeft = true;
		}
	}
}
