using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Attesa : MonoBehaviour {

	int scelta=PresaBottone.scelta;

	void Update(){
		StartCoroutine (Attendi());//Fa partire una funzione "contatore"  
	}
	IEnumerator Attendi(){
		yield return new WaitForSeconds (3);//Attesa in secondi
		Debug.Log (Time.time);
		Scenari ();
	}
	void Scenari(){//In base alla scelta effettuata in PresaBottone, andrà in un determinato scenario
	switch (scelta){
		case 1:
			SceneManager.LoadScene("PacmanOriginaleFacile");
			break;
		case 2:
			SceneManager.LoadScene("PacmanModificatoNormale");
			break;
		case 3:
			SceneManager.LoadScene("PacmanModificatoDifficile");
			break;
		case 4:
			SceneManager.LoadScene("SnakeOriginaleFacile");
			break;
		case 5:
			SceneManager.LoadScene("SnakeModificatoNormale");
			break;
		case 6:
			SceneManager.LoadScene("SnakeModificatoDifficile");
			break;
		case 7:
			SceneManager.LoadScene("FlappyOriginaleFacile");
			break;
		case 8:
			SceneManager.LoadScene("FlappyModificatoNormale");
			break;
		case 9:
			SceneManager.LoadScene("FlappyModificatoDifficile");
			break;
		}
	}
}
