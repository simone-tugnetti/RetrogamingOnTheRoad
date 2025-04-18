using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SeguireDifficile : MonoBehaviour {
	public Transform waypoint;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Move", 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Move(){
		Vector2 p = Vector2.MoveTowards (transform.position, waypoint.position, 0.8f);
		GetComponent<Rigidbody2D>().MovePosition (p);
	}
}
