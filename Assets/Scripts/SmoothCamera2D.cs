using UnityEngine;
using System.Collections;

public class SmoothCamera2D : MonoBehaviour {
	


	public Transform target;
	
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{

			transform.position = new Vector3(target.position.x, target.position.y, -2.2f);
		}
		
	}
}