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
		this._move();
		this._checkBounds();
	}

	//
	private void _move ()
	{
		Vector2 newPosition = this._transform.position;
		newPosition.x -= this._speed;
		this._transform.position = newPosition;
	}

	//
	private void _checkBounds(){
		if (this._transform.position.x <= -80f) {
			this._reset ();
		}
	}

	private void _reset(){
		this._transform.position = new Vector2 (319.1f, 0f);
	}
}
