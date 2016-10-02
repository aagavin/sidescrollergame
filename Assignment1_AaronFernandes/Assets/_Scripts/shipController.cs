using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {


	/*
	 * Private varables
	 */ 
	private Transform _transform;


	/*
	 * public varables
	 */
	public GameController gameController;


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
			this.gameController.Compiler += 1;
			break;
		case "Two":
			this.gameController.Ram += 1;
			break;
		default:
			break;
			
		}
			
	}
}
