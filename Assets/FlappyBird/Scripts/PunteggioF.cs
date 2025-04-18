using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PunteggioF : MonoBehaviour {

    public static int score;

    Text text;
    void Start()
    {
        text = GetComponent<Text>();

        score = 0;
    }
    void Update()
    {
        text.text = "Punteggio: " + score;
    }
    public static void AddPoints(int pointsToAdd)
    {
		score += pointsToAdd;//Cambia il valore di score in base a cosa è passato per parametro in questo caso 1 (score=score+1) 
    }

    public static void Reset()//Quando viene resettato lo scenario, si resetta anche il punteggio
    {
        score = 0;
    }
}
