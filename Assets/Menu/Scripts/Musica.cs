using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour {
	float MusicTime;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);//Non elimina l'oggetto a cui è associato lo script
	}
	
	// Update is called once per frame
	void Update () {
		MusicTime = GetComponent<AudioSource>().time;//Salva il tempo della musica ad ogni frame
		if (Application.loadedLevelName == "GameOverS" || Application.loadedLevelName == "Classifica") {//Se vengono caricati gli scenari di game over o di classifica...
			GetComponent<AudioSource> ().Pause ();//...la musica andrà in pausa per permettere alle musiche di questi due scenari di non andare in sovrapposizione l'una con l'altra
		}
	}
	void OnLevelWasLoaded(int scena){//Questa funzione definisce quale scena è stata attivata in base a "scena" (l'index della scena in base alla build)
		if (scena == 1 || scena == 7 || scena == 8 || scena == 9 || scena == 10 || scena == 11 || scena == 12 || scena == 13 || scena == 14 || scena == 15)//Quando vengono caricate queste scene...
        {
            GetComponent<AudioSource>().time = MusicTime;//...il tempo della musica prende il valore preso in MusicTime
			GetComponent<AudioSource> ().Play ();//Avvia la musica con il tempo corretto
        }
	}
}
