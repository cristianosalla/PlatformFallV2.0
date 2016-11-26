using UnityEngine;
using System.Collections;

public class _Coin_Behaviour : MonoBehaviour {

	public GameObject Score_Point;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("collider_player")) {
			Instantiate (Score_Point);
			Destroy (gameObject);
				}
		if (other.gameObject.CompareTag ("death_line"))
			Debug.Log ("colidiu");
		Destroy (gameObject);
	}

}
