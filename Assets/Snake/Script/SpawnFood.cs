using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour {
	public GameObject foodPrefab;

	public Transform borderSu;
	public Transform borderGiu;
	public Transform borderSinistra;
	public Transform borderDestra;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", 2, 2);
	}
	void Spawn(){
		int x = (int)Random.Range (borderSinistra.position.x+1, borderDestra.position.x-1);//In base alle posizioni dei bordi, x prenderà un determinato valore random
		int y = (int)Random.Range (borderGiu.position.y+1, borderSu.position.y-1);
		Instantiate (foodPrefab, new Vector2 (x, y), Quaternion.identity);//Istanzia l'oggetto foodPrefab nelle posizioni x e y senza alcuna rotazione dell'oggetto
	}

}

