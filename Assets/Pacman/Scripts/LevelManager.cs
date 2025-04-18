using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public GameObject player;
	int x=22;
	int y=8;
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
