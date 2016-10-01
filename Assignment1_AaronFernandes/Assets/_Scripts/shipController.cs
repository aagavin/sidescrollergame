using UnityEngine;
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
}
