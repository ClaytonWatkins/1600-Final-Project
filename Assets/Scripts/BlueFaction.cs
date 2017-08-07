using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueFaction : MonoBehaviour {

    //PROPERTIES
    public float regen;
    public const float maxHealth = 100f;
    public float currentHealth = maxHealth;
	public static int AddGPoints;
	public int points;

	void Update(){
		if (currentHealth < maxHealth);
		StartCoroutine(Regen());
		}
	IEnumerator Regen(){
		while (currentHealth < maxHealth){
			HealthRegen();
			yield return new WaitForSeconds(5);
		}
	}
	public void TakeDamage(float amount){
		currentHealth -= amount;
		if (currentHealth <= 0){
			currentHealth = 0;
			AddGPoints += points;
			Destroy (gameObject);
		}
	}
	public void HealthRegen(){
		currentHealth += regen;
	}
}