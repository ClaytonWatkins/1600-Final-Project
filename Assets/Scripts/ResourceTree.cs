using UnityEngine;
using System.Collections;

public class ResourceTree : MonoBehaviour {

	public static int treeAddGPoints;
	public static int treeAddBPoints;
	public int points;
	public bool tree = false;

	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag("GreenFaction"));
		tree = true;
		InvokeRepeating("treeAdd", 2F, 5F);
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.CompareTag("GreenFaction"));
			tree = false;
			CancelInvoke();
	}

	void treeAdd(){
		if (tree = true){
			ResourceUI.treeAddGPoints(points);
		}
	}
}