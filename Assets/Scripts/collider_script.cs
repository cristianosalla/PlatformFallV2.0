using UnityEngine;
using System.Collections;

public class collider_script : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D other){
		
		if (other.gameObject.CompareTag ("snake")) {
			Application.LoadLevel(Application.loadedLevel);
		}
		
	}
}
