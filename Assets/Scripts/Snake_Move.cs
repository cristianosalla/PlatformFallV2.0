using UnityEngine;
using System.Collections;

public class Snake_Move : MonoBehaviour {

	public GameObject axis;

	void Update () {
	
		gameObject.transform.Translate (0.03f, 0, 0);
		if (gameObject.transform.position.x < -0.7f + axis.transform.position.x  || gameObject.transform.position.x > 0.7f + axis.transform.position.x) {
				
			gameObject.transform.Rotate (0,180,0);
		}
	}
	}
