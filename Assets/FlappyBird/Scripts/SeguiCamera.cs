using UnityEngine;
using System.Collections;

public class SeguiCamera : MonoBehaviour {

	public Transform target;
	// Update is called once per frame
	void LateUpdate () {//LateUpdate è utilizzato quando devono essere avviati altri Update prima di questo per permettere la ricezione di informazioni
		transform.position = new Vector3 (target.position.x, transform.position.y, transform.position.z);//In  base alla posizione del protagonista, cambierà la posizione della telecamera
	}
}
