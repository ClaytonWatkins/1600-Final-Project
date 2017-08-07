using UnityEngine;
using System.Collections;

public class ResetPostition : MonoBehaviour {

public Transform BSP;
public Transform GSP;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("GreenFaction")){
			other.transform.position = GSP.position;
			other.transform.rotation = GSP.rotation;
	}
		if (other.gameObject.CompareTag("BlueFaction")){
			other.transform.position = BSP.position;
			other.transform.rotation = BSP.rotation;
	}
	}
}