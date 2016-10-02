﻿using UnityEngine;
using System.Collections;

public class shipController : MonoBehaviour {

	private Transform _transform;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._transform.position = new Vector2(-270.3f, Mathf.Clamp(Input.mousePosition.y-250, -183.8f, 183.8f) );
	}


	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="other">Other.</param>
	void OnTriggerEnter2D (Collider2D other){

		switch (other.tag) {
		case "One":
		case "Zero":
			Debug.Log ("HIT ONE & ZERO");
			break;
		case "Two":
			Debug.Log ("HIT TOW");
			break;
		default:
			break;
			
		}
			
	}
}
