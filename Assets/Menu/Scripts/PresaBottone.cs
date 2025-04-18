using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//Main Project
public class PresaBottone : MonoBehaviour {
	public static int scelta;


	public void NuovaPartita(){
			SceneManager.LoadScene("MenuGiochi");
	}


	public void Esci(){
			Application.Quit();
	}


	public void Pacman(){
		SceneManager.LoadScene ("PacmanModalita");
	}


	public void pacModFacile(){
		scelta = 1;
		SceneManager.LoadScene ("Attesa");
	}


	public void pacModNormale(){
		scelta = 2;
		SceneManager.LoadScene ("Attesa");
	}


	public void pacModDifficile(){
		scelta = 3;
		SceneManager.LoadScene ("Attesa");
	}


	public void Snake(){
		SceneManager.LoadScene ("SnakeModalita");
	}


	public void SnaModFacile(){
		scelta = 4;
		SceneManager.LoadScene ("Attesa");
	}


	public void SnaModNormale(){
		scelta = 5;
		SceneManager.LoadScene ("Attesa");
	}


	public void SnaModDifficile(){
		scelta = 6;
		SceneManager.LoadScene ("Attesa");
	}


	public void FlappyBird(){
		SceneManager.LoadScene ("FlappyBirdModalita");
	}


	public void FlaModFacile(){
		scelta = 7;
		SceneManager.LoadScene ("Attesa");
	}


	public void FlaModNormale(){
		scelta = 8;
		SceneManager.LoadScene ("Attesa");
	}


	public void FlaModDifficile(){
		scelta = 9;
		SceneManager.LoadScene ("Attesa");
	}


	public void TornaIndietro(){
		SceneManager.LoadScene ("Menu");
	}

	public void Riprova(){//Funzione che richiama la scena in cui si ha perso/vinto in base alla scelta iniziale
		switch (scelta){
		case 1:
			pacModFacile ();
			break;
		case 2:
			pacModNormale ();
			break;
		case 3:
			pacModDifficile ();
			break;
		case 4:
			SnaModFacile ();
			break;
		case 5:
			SnaModNormale ();
			break;
		case 6:
			SnaModDifficile ();
			break;
		case 7:
			FlaModFacile ();
			break;
		case 8:
			FlaModNormale ();
			break;
		case 9:
			FlaModDifficile ();
			break;
		}
	}
	public void Indietro(){
			SceneManager.LoadScene ("MenuGiochi");
	}

}