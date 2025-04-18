using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GhostMove : MonoBehaviour {
	public Transform[] waypoints;//Array di posizioni
	int cur=0;

	public float speed = 0.3f;

	// Update is called once per frame
	void FixedUpdate () {//Si utilizza quando si ha a che fare con corpi fisici. Viene richiamato non per ogni frame ma per ogni frame fixato, cioè in un tempo migliorato
		if (transform.position != waypoints[cur].position) {
			Vector2 p = Vector2.MoveTowards (transform.position, waypoints[cur].position, speed);
			GetComponent<Rigidbody2D>().MovePosition (p);//L'oggetto si muoverà verso la prossima posizione selezionata in wayponts[cur]
		} else cur = (cur + 1) % waypoints.Length;//Se è stato raggiunto un waypoint, allora verrà aumentato di 1 l'indice dell'array e se cur==waypoints.Lenght --> cur=0

		Vector2 dir = waypoints[cur].position - transform.position;//Prende la posizione verso cui si deve muovere
		GetComponent<Animator>().SetFloat("DirX", dir.x);//Cambia il valore DirX e in base a esso ci sarà una diversa animazione
		GetComponent<Animator>().SetFloat("DirY", dir.y);
	}
	void OnTriggerEnter2D(Collider2D co){
		if (co.name == "pacman")
			Destroy (co.gameObject);
	}
}
