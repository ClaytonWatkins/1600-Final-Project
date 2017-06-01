using UnityEngine;
using System.Collections;

public class GenderMale : MonoBehaviour {

	//PROPERTIES 
	//Characters have thicker features and larger size
	//Males are slower (speed -= 2)
	//Males do less (damage += 2)
	public string Gender  = "GenderMale";

	// Use this for initialization
	void Awake() {
		if (GenderMale){
			speed (speed -= 2);
			damage (damage += 2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
