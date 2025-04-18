using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour {

	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;

	void Start() {
		dest = transform.position;
	}

	void FixedUpdate() {
		
		Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		GetComponent<Rigidbody2D>().MovePosition(p);
		if ((Vector2)transform.position == dest) {
			if (Input.GetKey (KeyCode.UpArrow) && valid (Vector2.up)) {//Se si preme Su e non ci sono muri verso l'alto...
				dest = (Vector2)transform.position + Vector2.up;//La variabile dest prenderà la posizione di pacman + la posizione verso l'alto all'interno dello spazio
			}
			if (Input.GetKey (KeyCode.RightArrow) && valid (Vector2.right)) {
				dest = (Vector2)transform.position + Vector2.right;
			}
			if (Input.GetKey (KeyCode.DownArrow) && valid (-Vector2.up)) {
				dest = (Vector2)transform.position - Vector2.up;
			}
			if (Input.GetKey (KeyCode.LeftArrow) && valid (-Vector2.right)) {
				dest = (Vector2)transform.position - Vector2.right;
			}
		}
		Vector2 dir = dest - (Vector2)transform.position;//In base alla variabile dir...
		GetComponent<Animator>().SetFloat("DirX", dir.x);//...cambieranno le animazioni di pacman
		GetComponent<Animator>().SetFloat("DirY", dir.y);
	}

	bool valid(Vector2 dir) {
		
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);//Crea una linea immaginaria verso la direzione in cui si sta muovendo per controllare se davanti a pacman non esistono muri
		return (hit.collider == GetComponent<Collider2D>());
	}
}
