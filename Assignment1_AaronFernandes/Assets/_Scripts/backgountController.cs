using UnityEngine;
using System.Collections;

public class backgountController : MonoBehaviour {
	// privates
	private int _speed;
	private Transform _transform;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();

		this._speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 newPosition = this._transform.position;
		newPosition.x -= this._speed;
		this._transform.position = newPosition;
	//TODO Make backgourd move
	}
}
