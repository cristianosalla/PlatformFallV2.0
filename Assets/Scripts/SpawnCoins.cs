using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

	public Transform[] coinSpawns;
	public GameObject coin;
	public Transform snake_pos;
	public GameObject snake;
	
	void Start () {
	
		Spawn ();

	}

	void Spawn(){


		for (int i = 0; i < coinSpawns.Length; i++) {
			int coinFlip = Random.Range (0,2);
			if (coinFlip > 0)
				Instantiate(coin, coinSpawns[i].position, Quaternion.identity);

			int snakeFlip = Random.Range (0, 19);
			if (coinFlip == 0 && snakeFlip == 0)
				Instantiate (snake, snake_pos.position, Quaternion.identity);
		}
	}			
}


