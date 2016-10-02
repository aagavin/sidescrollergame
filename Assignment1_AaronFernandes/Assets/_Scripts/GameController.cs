using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	/*
	 * Private Varables
	 */
	private int _compiler=0;
	private int _ram=0;

	/*
	 * Public varables
	 */
	public Text compilerText;
	public Text ramText;

	/*
	 * Public propities
	 */
	public int Compiler {
		get{
			return this._compiler;
		}
		set{
			this._compiler=value;
			this.compilerText.text="Compile: "+this._compiler+"%";
		}
	}


	public int Ram {
		get
		{
			return this._ram;
		}
		set
		{

			this._ram = value;
			if (this._ram <= 9) {
				string text = "Ram: [";
				int lines=(10-this._ram);

				this.ramText.text = "";
				for (int i = 0; i < this._ram; i++) {text += "#";}
				for (int i = 0; i < lines; i++) {text += "_";}
				text += "]";

				this.ramText.text = text;
			} else {
				Debug.Log ("DEAD");
			}
		}
	}

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}


}
