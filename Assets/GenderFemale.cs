using UnityEngine;
using System.Collections;

public class GenderFemale : MonoBehaviour {

	//PROPERTIES 
	//Characters have slimmer features and smaller size
	//Females are faster (speed += 2)
	//Females do less (damage -= 2)
	public string Gender  = "GenderFemale";

	// Use this for initialization
	void Awake() {
		if (GenderFemale){
			slower (speed += 2);
			stronger (damage -= 2);
		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
