using UnityEngine;
using System.Collections;

public class Spell : MonoBehaviour {

	public float damage = 15;
	public float time = 4;

	void Start(){
			Destroy (gameObject, time);
        }

	void OnCollisionEnter(Collision other)
	{
		var hit = other.gameObject;
		var health = hit.GetComponent<BlueFaction>();

		if (health != null){
			health.TakeDamage(damage);
		}
	}
}