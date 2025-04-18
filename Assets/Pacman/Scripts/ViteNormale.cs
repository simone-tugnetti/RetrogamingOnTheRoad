using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViteNormale : MonoBehaviour {

	public static int vite;

	Text text;
	void Start(){
		text = GetComponent<Text> ();

		vite = 4;
	}
	void Update(){
		text.text = "Vite: " + vite;
	}
	public static void AddPoints (int pointsToAdd){
		vite -= pointsToAdd;
	}

	public static void Reset (){
		vite = 4;
	}

}
