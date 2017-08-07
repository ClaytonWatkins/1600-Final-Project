using UnityEngine;
using System.Collections;

public class ResourceTree : MonoBehaviour {

	public static int treeAddGPoints;
	public static int treeAddBPoints;
	public int points = 5;
	public bool trees = false;

	void OnTriggerStay (Collider other){
		if (other.gameObject.CompareTag("GreenFaction"));
			StartCoroutine(treeAdds());
			trees = true;
	}
		IEnumerator treeAdds(){
			if (trees = true);
			yield return new WaitForSeconds(5);	
			treeAddsG();
    }
	public void treeAddsG(){
		treeAddGPoints += (points);
		}
}