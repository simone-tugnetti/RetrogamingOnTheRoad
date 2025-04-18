using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
	Text text;
	int scelta=PresaBottone.scelta;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		switch (scelta) {//In base alla scelta, visualizza il corrispettivo Higscore
		case 1:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscorePFNome")+": "+PlayerPrefs.GetInt("highscorePF");
			break;
		case 2:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscorePNNome")+": "+PlayerPrefs.GetInt("highscorePN");
			break;
		case 3:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscorePDNome")+": "+PlayerPrefs.GetInt("highscorePD");
			break;
		case 4:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreSFNome")+": "+PlayerPrefs.GetInt("highscoreSF");
			break;
		case 5:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreSNNome")+": "+PlayerPrefs.GetInt("highscoreSN");
			break;
		case 6:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreSDNome")+": "+PlayerPrefs.GetInt("highscoreSD");
			break;
		case 7:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreFFNome")+": "+PlayerPrefs.GetInt("highscoreFF");
			break;
		case 8:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreFNNome")+": "+PlayerPrefs.GetInt("highscoreFN");
			break;
		case 9:
			text.text = "Highscore --> " + PlayerPrefs.GetString("highscoreFDNome")+": "+PlayerPrefs.GetInt("highscoreFD");
			break;
		}
	}
}
