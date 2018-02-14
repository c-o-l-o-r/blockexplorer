﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {

	public GameObject game_manager;
	public bool gameCanStart;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameCanStart && Input.GetKeyDown ("space")) {
			gameCanStart = false;

			block b = GetComponent<block> ();
			Debug.Log (b.height + " weeee");

			game_manager.GetComponent<GameManager>().enter_mini_game(b.height);

			Debug.Log ("contact with block: " + b.height);

		}
	}


	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			//Debug.Log (other.name);
			gameCanStart = true;
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			gameCanStart = false;
		}
	}
		
}

