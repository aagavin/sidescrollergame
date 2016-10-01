using UnityEngine;
using System.Collections;

public class numberController : MonoBehaviour {

	//private varables
	private int _speed;
	private Transform _transform;
	private float _randomY;

	// Use this for initialization
	void Start () {
		this._transform = this.GetComponent<Transform> ();
		this.generateRandomSpeed ();
		this.generateRandomY ();
	}
	
	// Update is called once per frame
	void Update () {
		this._move ();
		this._checkBounds ();
	}

	private void generateRandomSpeed(){
		this._speed = Random.Range (4, 12);
	}

	private void generateRandomY(){
		this._randomY = Random.Range (-220f, 220f);
	}

	/// <summary>
	/// Moves the number baised on a random speed value
	/// </summary>
	private void _move(){
		this._transform.position = new Vector2 (this._transform.position.x - this._speed, this._randomY);
	}

	/// <summary>
	/// Checks the bounds of a number
	/// </summary>
	private void _checkBounds(){
		if (this._transform.position.x <= -333f) {
			this._reset ();
		}
	}


	private void _reset(){
		this.generateRandomY ();
		this._transform.position = new Vector2 (338f,this._randomY);
	}
}
