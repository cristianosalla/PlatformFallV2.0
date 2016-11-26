using UnityEngine;
using System.Collections;

public class ScorePoints : MonoBehaviour {


	public int Score;
	public TextMesh Score_Texto;

	void Awake(){
		Score++;
		Debug.Log (Score);
		Debug.Log ("heheheheh");
		Destroy (gameObject);
	}

	void Start () {
	}


	void Update () {
		Score_Texto.text = Score.ToString ();
	}
}
