using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueFaction : MonoBehaviour {

    //PROPERTIES
    public float regen;
    public const float maxHealth = 100f;
    public static float currentHealth = maxHealth;
	public static int AddGPoints;
	public int points;
	public float repeatTime = 5f;

	void Awake(){
		currentHealth = maxHealth;
		InvokeRepeating("Regen", 2f, repeatTime);
	}

	void Regen(){
		if (currentHealth < maxHealth){
			currentHealth += regen;
		}
	}
	public void Update(){
		if (currentHealth <= 0){
			currentHealth = 0;
			ResourceUI.AddGPoints(points);
			Destroy (gameObject);}
		}

	public static void TakeDamage(float damage){
		currentHealth -= damage;
		}
}