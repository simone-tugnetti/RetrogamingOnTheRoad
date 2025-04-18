using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViteDifficile : MonoBehaviour {

	public static int vite;

	Text text;
	void Start(){
		text = GetComponent<Text> ();

		vite = 3;
	}
	void Update(){
		text.text = "Vite: " + vite;
	}
	public static void AddPoints (int pointsToAdd){
		vite -= pointsToAdd;
	}

	public static void Reset (){
		vite = 3;
	}

}
