using UnityEngine;
using System.Collections;

public class LevelManagerDifficile : MonoBehaviour {
	
	public GameObject player;
	int x=19;
	int y=23;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		yield return new WaitForSeconds (2);
		Instantiate (player, new Vector2 (x, y),Quaternion.identity);
	}
}
