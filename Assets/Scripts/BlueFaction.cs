using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlueFaction : MonoBehaviour {

    //PROPERTIES
    public float regen;
    public const float maxHealth = 100f;
    public float currentHealth = maxHealth;
	public string size = "medium";
	public Transform spawnPoint;

	void OnCollisionEnter(Collision other){
		StartCoroutine(Regen());
		}

	IEnumerator Regen(){
		while(currentHealth<maxHealth){
			yield return new WaitForSeconds(3);
			print("Health at " + currentHealth);			
			currentHealth += regen;
            }
		}
	/*void Update(){
		HP.text = currentHealth.ToString();
		maxHP.text = maxHealth.ToString();	
		}*/

	public void TakeDamage(float amount){
		currentHealth -= amount;
		if (currentHealth <= 0){
			currentHealth = 0;
			Destroy (gameObject);
            //add points to score for killing the wolf
			/*scoreManager.addPoints(points);*/
            //move wolf to spawn point
            /*transform.position = spawnPoint.position;
			transform.rotation = spawnPoint.rotation;*/
            currentHealth = maxHealth;
		}
	}
}