using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MorteDifficile : MonoBehaviour {
	int score;
	int pointsToAdd=1;
	public LevelManagerDifficile levelManager;

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "blinky" || co.name == "pinky" || co.name == "yelly" || co.name == "azzurry" || co.name=="violly") {
			ViteDifficile.AddPoints (pointsToAdd);
			Destroy (gameObject);
			if (ViteDifficile.vite > 0) {
				levelManager.RespawnPlayer ();
			} else {
				if (score > PlayerPrefs.GetInt ("highscorePD")) {
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
		levelManager= FindObjectOfType<LevelManagerDifficile> ();
	}
	
	// Update is called once per frame
	void Update () {
		score = Punteggio.score;
		if (score == 329) {
			SceneManager.LoadScene ("Classifica");
		}
	}
}
