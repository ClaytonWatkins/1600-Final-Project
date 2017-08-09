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
		if (other.gameObject.CompareTag("BlueFaction"));
			BlueFaction.TakeDamage(damage);
	}
}