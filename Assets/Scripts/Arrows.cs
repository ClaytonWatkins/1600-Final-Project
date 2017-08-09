using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour {
    
	public float damage = 10;
	public float time = 4;

	void Start(){
			Destroy (gameObject, time);
        }

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("GreenFaction"));
			GreenFaction.TakeDamage(damage);
	}
}