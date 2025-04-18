using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Punteggio : MonoBehaviour {
	public static int score;

	Text text;
	void Start(){
		text = GetComponent<Text> ();

		score = 0;
	}
	void Update(){
		text.text = "Punteggio: " + score;
	}
	public static void AddPoints (int pointsToAdd){
		score += pointsToAdd;
	}

	public static void Reset (){
		score = 0;
	}
}