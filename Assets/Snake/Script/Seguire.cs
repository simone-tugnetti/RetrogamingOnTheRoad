using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Seguire : MonoBehaviour {
	public Transform waypoint;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Move", 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Move(){
		Vector2 p = Vector2.MoveTowards (transform.position, waypoint.position, 0.7f);//MoveTowards è una funzione che simula un inseguimento verso un determinato oggetto con una determinata velocità
		GetComponent<Rigidbody2D>().MovePosition (p);//Questa funzione implementa l'inseguimento cambiando la posizione in base a quella generata da MoveTowards
	}
}
