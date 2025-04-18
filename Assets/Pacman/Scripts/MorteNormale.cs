using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MorteNormale : MonoBehaviour {
	int score;
	int pointsToAdd=1;
	public LevelManagerNormale levelManager;

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "blinky" || co.name == "pinky" || co.name == "yelly" || co.name == "azzurry" || co.name=="violly") {
			ViteNormale.AddPoints (pointsToAdd);
			Destroy (gameObject);
			if (ViteNormale.vite > 0) {
				levelManager.RespawnPlayer ();
			} else {
				if (score > PlayerPrefs.GetInt ("highscorePN")) {
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
		levelManager= FindObjectOfType<LevelManagerNormale> ();
	}
	
	// Update is called once per frame
	void Update () {
		score = Punteggio.score;
		if (score == 287) {
			SceneManager.LoadScene ("Classifica");
		}
	}
}
