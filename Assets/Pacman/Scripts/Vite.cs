using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vite : MonoBehaviour {

	public static int vite;

	Text text;
	void Start(){
		text = GetComponent<Text> ();

		vite = 5;
	}
	void Update(){
		text.text = "Vite: " + vite;
	}
	public static void AddPoints (int pointsToAdd){
		vite -= pointsToAdd;//Ogni volta che si viene toccati dai fantasmi le vite diminuiranno di 1
	}

	public static void Reset (){
		vite = 5;
	}

}
