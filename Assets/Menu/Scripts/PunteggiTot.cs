using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PunteggiTot : MonoBehaviour {
	Text text;
	int scelta=PresaBottone.scelta;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		switch (scelta) {//Visualizza il punteggio ottenuto nelle scene corrette
		case 1:
			int punteggioPF = Punteggio.score;
			text.text = "Punteggio: " + punteggioPF;
			break;
		case 2:
			int punteggioPN = Punteggio.score;
			text.text = "Punteggio: " + punteggioPN;
			break;
		case 3:
			int punteggioPD = Punteggio.score;
			text.text = "Punteggio: " + punteggioPD;
			break;
		case 4:
			int punteggioSF = PunteggioSnake.score;
			text.text = "Punteggio: " + punteggioSF;
			break;
		case 5:
			int punteggioSN = PunteggioSnake.score;
			text.text = "Punteggio: " + punteggioSN;
			break;
		case 6:
			int punteggioSD = PunteggioSnake.score;
			text.text = "Punteggio: " + punteggioSD;
			break;
		case 7:
			int punteggioFF = PunteggioF.score;
			text.text = "Punteggio: " + punteggioFF;
			break;
		case 8:
			int punteggioFN = PunteggioF.score;
			text.text = "Punteggio: " + punteggioFN;
			break;
		case 9:
			int punteggioFD = PunteggioF.score;
			text.text = "Punteggio: " + punteggioFD;
			break;
		}
	}
}
