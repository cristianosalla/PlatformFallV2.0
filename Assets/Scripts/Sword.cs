using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {

	public GameObject snake;

	void OnCollisionEnter2D (Collision2D other){

		if (other.gameObject.CompareTag ("snake")) {
				Destroy(other.gameObject);
		}

	}

}
