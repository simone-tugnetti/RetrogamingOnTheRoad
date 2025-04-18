using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour {
	int score;
	int pointsToAdd=1;
	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "blinky" || co.name == "pinky" || co.name == "yelly" || co.name == "azzurry") {
			Vite.AddPoints (pointsToAdd);
			Destroy (gameObject);
			if (Vite.vite > 0) {
				levelManager.RespawnPlayer ();//se le vite sono maggiori di 0, verrà richiamata la funzione di Respawn che provvederà a far ricreare pacman
			} else {
				if (score > PlayerPrefs.GetInt ("highscorePF")) {
					SceneManager.LoadScene ("Classifica");
				}
				else{
					SceneManager.LoadScene ("GameOverS");
				}
			}
		}

	}

	// Use this for initialization
	void Start () {
		levelManager= FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		score = Punteggio.score;
		if (score == 329) {//Se si sono mangiati tutti i pacdot, si andrà direttamente alla schermata di classifica
			SceneManager.LoadScene ("Classifica");
		}
	}
}
