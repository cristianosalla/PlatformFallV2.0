using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {

	public float fallDelay = 2f;
	public float ActiveDelay = 3f;



	public GameObject plat;
	public GameObject playy;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Awake () {
	
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame


	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.CompareTag ("Player")) {

			Invoke("Fall", fallDelay);	
			Invoke("Active", ActiveDelay);
		}

	}

	void Update(){
		

	
	}
	void Active(){
		Destroy (gameObject);
	
	
	}
	void Fall(){
		rb2d.isKinematic = false;

	}

}
