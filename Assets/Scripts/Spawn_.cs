using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn_ : MonoBehaviour {


	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;

	public GameObject platform;

	public List<GameObject> plat;

	public int maxRate;

	private Vector2 originPosition;

	void Start () {
	
		originPosition = transform.position;

		for (int i = 0; i < maxRate; i++) {
			Vector2 randomPosition = originPosition + new Vector2(Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			GameObject tempPlat = Instantiate(platform) as GameObject;
			tempPlat.transform.position = new Vector2(randomPosition.x, randomPosition.y);
			plat.Add (tempPlat);		

			originPosition = randomPosition;
		}
	
	}
	
	void Update () {
		for(int i = 0; i < maxRate ; i++){
		if (plat [i] == null) {		
				Vector2 randomPosition = originPosition + new Vector2(Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
				plat[i] = Instantiate(platform) as GameObject;
				plat[i].transform.position = new Vector2(randomPosition.x, randomPosition.y);
				originPosition = randomPosition;

		}
		}
	}

	void Spawn(){

		GameObject plat = Instantiate (platform) as GameObject;

	}
}
