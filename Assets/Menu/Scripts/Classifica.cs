using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Classifica : MonoBehaviour {
    int scelta = PresaBottone.scelta;

	string stringpac;
	int puntpac;
	string stringpacNormale;
	int puntpacNormale;
    string stringpacDifficile;
    int puntpacDifficile;
    string stringSnaFacile;
    int puntSnaFacile;
	string stringSnaNormale;
	int puntSnaNormale;
	string stringSnaDifficile;
	int puntSnaDifficile;
	string stringFlaFacile;
	int puntFlaFacile;
	string stringFlaNormale;
	int puntFlaNormale;
	string stringFlaDifficile;
	int puntFlaDifficile;

	void Start(){
	}

    public void Classi(){
        switch (scelta)
        {
		case 1:
			int punteggioPF = Punteggio.score;//Prendo il punteggio ottenuto nel minigioco
			puntpac = punteggioPF;
			stringpac = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;//Prende il testo all'interno dell'oggetto text
			if (stringpac == null || stringpac == "") {
				stringpac = "Anonimo";
			}
				PlayerPrefs.SetInt ("highscorePF", puntpac);//Setto il dato ottenuto nel punteggio e gli assegno una chiave con un determinato nome
				PlayerPrefs.SetString ("highscorePFNome", stringpac);
				PlayerPrefs.Save ();//Salvo in modo permanente le preferenze
				Debug.Log (PlayerPrefs.GetString("highscorePFNome")+": "+PlayerPrefs.GetInt("highscorePF"));//Scrivo all'interno del debug i dati
	                break;
			case 2:
				int punteggioPN = Punteggio.score;
				puntpacNormale = punteggioPN;
				stringpacNormale = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringpacNormale == null || stringpacNormale == "") {
					stringpacNormale = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscorePN", puntpacNormale);
				PlayerPrefs.SetString ("highscorePNNome", stringpacNormale);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscorePNNome")+": "+PlayerPrefs.GetInt("highscorePN"));
	                break;
			case 3:
				int punteggioPD = Punteggio.score;
				puntpacDifficile = punteggioPD;
				stringpacDifficile = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringpacDifficile == null || stringpacDifficile == "") {
					stringpacDifficile = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscorePD", puntpacDifficile);
				PlayerPrefs.SetString ("highscorePDNome", stringpacDifficile);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscorePDNome")+": "+PlayerPrefs.GetInt("highscorePD"));
	                break;
            case 4:
                int punteggioSF = PunteggioSnake.score;
                puntSnaFacile = punteggioSF;
				stringSnaFacile = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringSnaFacile == null || stringSnaFacile == "") {
					stringSnaFacile = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreSF", puntSnaFacile);
				PlayerPrefs.SetString ("highscoreSFNome", stringSnaFacile);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreSFNome")+": "+PlayerPrefs.GetInt("highscoreSF"));
                	break;
            case 5:
				int punteggioSN = PunteggioSnake.score;
				puntSnaNormale = punteggioSN;
				stringSnaNormale = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringSnaNormale == null || stringSnaNormale == "") {
					stringSnaNormale = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreSN", puntSnaNormale);
				PlayerPrefs.SetString ("highscoreSNNome", stringSnaNormale);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreSNNome")+": "+PlayerPrefs.GetInt("highscoreSN"));
                	break;
			case 6:
				int punteggioSD = PunteggioSnake.score;
				puntSnaDifficile = punteggioSD;
				stringSnaDifficile = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringSnaDifficile == null || stringSnaDifficile == "") {
					stringSnaDifficile = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreSD", puntSnaDifficile);
				PlayerPrefs.SetString ("highscoreSDNome", stringSnaDifficile);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreSDNome")+": "+PlayerPrefs.GetInt("highscoreSD"));
					break;
			case 7:
				int punteggioFF = PunteggioF.score;
				puntFlaFacile = punteggioFF;
				stringFlaFacile = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringFlaFacile == null || stringFlaFacile == "") {
					stringFlaFacile = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreFF", puntFlaFacile);
				PlayerPrefs.SetString ("highscoreFFNome", stringFlaFacile);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreFFNome")+": "+PlayerPrefs.GetInt("highscoreFF"));
					break;
			case 8:
				int punteggioFN = PunteggioF.score;
				puntFlaNormale = punteggioFN;
				stringFlaNormale = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringFlaNormale == null || stringFlaNormale == "") {
					stringFlaNormale = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreFN", puntFlaNormale);
				PlayerPrefs.SetString ("highscoreFNNome", stringFlaNormale);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreFNNome")+": "+PlayerPrefs.GetInt("highscoreFN"));
					break;
			case 9:
				int punteggioFD = PunteggioF.score;
				puntFlaDifficile = punteggioFD;
				stringFlaDifficile = GameObject.FindGameObjectWithTag ("Input").GetComponent<Text> ().text;
				if (stringFlaDifficile == null || stringFlaDifficile == "") {
					stringFlaDifficile = "Anonimo";
				}
				PlayerPrefs.SetInt ("highscoreFD", puntFlaDifficile);
				PlayerPrefs.SetString ("highscoreFDNome", stringFlaDifficile);
				PlayerPrefs.Save ();
				Debug.Log (PlayerPrefs.GetString("highscoreFDNome")+": "+PlayerPrefs.GetInt("highscoreFD"));
					break;
        }
    }

	public void GameOver(){
		SceneManager.LoadScene ("GameOverS");//Carica la schermata di game over
	}
}