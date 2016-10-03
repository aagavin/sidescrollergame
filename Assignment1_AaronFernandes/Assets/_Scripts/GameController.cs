using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
			if (this._compiler < 100) {
				this.compilerText.text = "Compile: " + this._compiler + "%";
			} else {
				SceneManager.LoadScene ("Win");
			}
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
				//Debug.Log ("DEAD");
				SceneManager.LoadScene("Loose");
			}
		}
	}

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}


}
