using UnityEngine;
using System.Collections;

public class Ostacoli : MonoBehaviour {

	public float speed = 1;//Possibile modificarlo all'interno dell'area di sviluppo
	public float switchTime=2;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;//Cambia la velocità  degli ostacoli mettendo: la posizione verso l'alto per la velocità, cioè la velocità con cui l'oggetto va verso l'alto
		InvokeRepeating ("Switch", 0, switchTime);//Ripete l'invocazione della funzione con la velocità di switchtime
	}
	
	void Switch(){
		GetComponent<Rigidbody2D> ().velocity *= -1;//Cambia la posizione dell'oggetto da verso l'alto a verso il basso e viceversa
	}
}
