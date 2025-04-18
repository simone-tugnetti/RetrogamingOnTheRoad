using UnityEngine;
using System.Collections;

public class LevelManagerNormale : MonoBehaviour {
	public GameObject player;
	float x=15.5f;
	float y=13.5f;
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
