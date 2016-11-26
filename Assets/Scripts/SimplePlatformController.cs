using UnityEngine;
using System.Collections;

public class SimplePlatformController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = true;

	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce;
	public Transform groundCheck;

	public bool isLefting = false;
	public bool isRighting = false;

	private bool grounded = false;
	public  Animator anim;
	private Rigidbody2D rb2d;

	public GameObject snake;

	public GameObject sword;

	void Awake(){
		anim = GetComponent<Animator> ();
		rb2d = GetComponent < Rigidbody2D> ();
	}

	void Update () {

		if(gameObject.transform.position.y < -30)
			Application.LoadLevel(Application.loadedLevel);

		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

		if (!grounded) {
			anim.SetBool ("isJumping", true);
		} else {
			anim.SetBool ("isJumping", false);
		}

		if (Input.GetButtonDown("x")) {	
			anim.SetBool ("isHitting", true);
			sword.SetActive(true);
			Invoke ("desHit", 0.6f);
		}

		if (Input.GetButtonDown ("c") && grounded) {
						jump = true;
			} 
		//&& Input.GetAxis ("Horizontal") != 0
		if (grounded &&(isLefting || isRighting) ) {
			anim.SetBool ("IsWalking", true);
		} else {
			anim.SetBool ("IsWalking", false);
		}

	}

	void desHit(){
		anim.SetBool ("isHitting", false);
		sword.SetActive (false);
	}

	void FixedUpdate(){
		float h = Input.GetAxis("Horizontal");

		if (isRighting == true) {
		
			if (rb2d.velocity.x < maxSpeed) 
				rb2d.AddForce(Vector2.right * moveForce);
		}

		if (isLefting == true) {
		
			if (rb2d.velocity.x < maxSpeed) 
				rb2d.AddForce(-Vector2.right * moveForce);
		}

//		if (h * rb2d.velocity.x < maxSpeed) 
//			rb2d.AddForce(Vector2.right * h * moveForce);
//		
//		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed)
//						rb2d.velocity = new Vector2 (Mathf.Sign (rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

		if (isRighting && !facingRight)
			Flip ();
		else if (isLefting && facingRight)
			Flip ();

//		if (h > 0 && !facingRight)
//						Flip ();
//				else if (h < 0 && facingRight)
//						Flip ();

		if (jump) {
			rb2d.AddForce(new Vector2(0f, jumpForce));
			jump = false;

		}

	}

	public void Left(){
		isLefting = true;
	
	}

	public void DesLeft(){
		isLefting = false;
	}



	public void Right(){

		isRighting = true;
	}

	public void DesRight(){
		isRighting = false;
	}



	public void Fight(){
		anim.SetBool ("isHitting", true);
		sword.SetActive(true);
		Invoke ("desHit", 0.6f);
	}

	public void Jump(){
		if (grounded) {
			rb2d.AddForce (new Vector2 (0f, jumpForce));
			jump = false;
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
