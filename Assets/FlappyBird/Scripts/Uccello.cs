using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Uccello : MonoBehaviour {
	int scelta=PresaBottone.scelta;

	public float speed = 2;
	public float force = 300;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;//Il personaggio continuerà ad andare verso destra ad una determinata velocità
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {//Quando il gioco rileva la pressione del tasto "Barra spaziatrice"...
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * force);//...Applicherà un cambiamento al rigidbody che altro non è che l'aggiunta di un cambiamento di posizione verso l'alto moltiplicata per una forza determinata che va in contrapposizione con la gravità dell'oggetto
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.name.StartsWith("ground") || coll.name.StartsWith("obstacle"))
        {
			switch (scelta) {
			case 7:
				if (PunteggioF.score > PlayerPrefs.GetInt ("highscoreFF")) {//Se il punteggio raggiunto nel gioco è maggiore dell'highscore dello stesso gioco, allora andrà nella schermata di classifica per salvarlo con il nome del giocatore...
					SceneManager.LoadScene ("Classifica");
				} else {//...altrimenti andrà nella schermata di Game Over
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			case 8:
				if (PunteggioF.score > PlayerPrefs.GetInt ("highscoreFN")) {
					SceneManager.LoadScene ("Classifica");
				} else {
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			case 9:
				if (PunteggioF.score > PlayerPrefs.GetInt ("highscoreFD")) {
					SceneManager.LoadScene ("Classifica");
				} else {
					SceneManager.LoadScene ("GameOverS");
				}
				break;
			}
        }
		if (coll.name.StartsWith ("Finish")) {//Se colliderà con la fine del livello, andrà direttamente nella schermata "Classifica"
			SceneManager.LoadScene ("Classifica");
		}
	}

    
}
