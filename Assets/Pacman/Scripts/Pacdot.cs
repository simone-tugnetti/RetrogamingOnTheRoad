using UnityEngine;
using System.Collections;

public class Pacdot : MonoBehaviour {

	int pointsToAdd=1;

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman" || co.name.StartsWith("PacmanPrefab")|| co.name.StartsWith("PacmanNormalePrefab") || co.name.StartsWith("PacmanDifficilePrefab")) {
			Punteggio.AddPoints (pointsToAdd);
			Destroy (gameObject);
		}
	}
}
