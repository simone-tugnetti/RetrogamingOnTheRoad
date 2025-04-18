using UnityEngine;
using System.Collections;

public class Moneta : MonoBehaviour {

    int pointsToAdd = 1;

    void OnTriggerEnter2D(Collider2D co)//Chiama questa funzione quando un oggetto non Is trigger collide con uno Is trigger
    {
		if (co.name == "bird" || co.name=="Maturando")//Quando viene toccato da uno di questi 2 oggetti...
        {
			PunteggioF.AddPoints(pointsToAdd);//Chiama la funzione AddPoints presente in PunteggioF passandogli come parametro pointsToAdd, cioè 1
            Destroy(gameObject);
        }
    }
}
