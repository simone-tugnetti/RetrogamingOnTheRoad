using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour {
	int scelta=PresaBottone.scelta;
	int pointsToAdd=10;
	Vector2 dir=Vector2.right;
	List<Transform> tail=new List<Transform>();//Creo una lista di posizioni
	bool ate=false;
	public GameObject tailPrefab;

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.name.StartsWith ("foodPrefab")) {
			Debug.Log ("Mangiato!!!");
			ate = true;
			PunteggioSnake.AddPoints (pointsToAdd);
			Destroy (coll.gameObject);
		}
		if(coll.name.StartsWith("TestaPrefab") || coll.name=="borderSu" || coll.name=="borderGiu" || coll.name=="borderSinistra" || coll.name=="borderDestra" || coll.name.StartsWith("nemico")){
			Debug.Log ("Toccato!");
			switch (scelta) {
			case 4:
				if (PunteggioSnake.score > PlayerPrefs.GetInt ("highscoreSF")) {
					SceneManager.LoadScene ("Classifica");
				} else {
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			case 5:
				if (PunteggioSnake.score > PlayerPrefs.GetInt ("highscoreSN")) {
					SceneManager.LoadScene ("Classifica");
				} else {
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			case 6:
				if (PunteggioSnake.score > PlayerPrefs.GetInt ("highscoreSD")) {
					SceneManager.LoadScene ("Classifica");
				} else {
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			}
		}
	}

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Move", 0.1f, 0.1f);
	}
	
	// Update is called once per frame
	void Update () {//In base al tasto premuto, dir prenderà una determinata posizione
		if (Input.GetKey (KeyCode.RightArrow))
			dir = Vector2.right;
		else if (Input.GetKey (KeyCode.DownArrow))
			dir = -Vector2.up;//Su
		else if (Input.GetKey (KeyCode.LeftArrow))
			dir = -Vector2.right;//Sinistra
		else if (Input.GetKey (KeyCode.UpArrow))
			dir = Vector2.up;
	}

	void Move(){
		Vector2 v = transform.position;//Prende la posizione effettiva dell'oggetto
		transform.Translate (dir);//Utilizza la direzione salvata in precedenza da dir e la utilizza ogni volta che viene richiamata la funzione per simulare il movimento di snake
		if (ate) {//Se snake ha mangiato un foodPrefab...
			GameObject g = (GameObject)Instantiate (tailPrefab, v, Quaternion.identity);//Istanzia un altro oggetto snake nella posizione effettiva di snake
			tail.Insert (0, g.transform);//Esegue l'inserimento di questo snake come se fosse una coda che segue la testa
			ate = false;
		} else if (tail.Count > 0) {//Se la lista è maggiore di 0...
			tail.Last ().position = v;//...l'ultimo oggetto della lista prende la posizione dell'ultimo oggetto creato
			tail.Insert (0, tail.Last ());//Viene inserito un altro oggetto Snake dopo la testa
			tail.RemoveAt (tail.Count - 1);//Distanzia il primo Snake dopo la testa e ne crea un altro in mezzo alla coda ed alla testa
		}
		}
}
