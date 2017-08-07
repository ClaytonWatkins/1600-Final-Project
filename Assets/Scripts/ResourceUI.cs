using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour {

private static int gScore;
private static int bScore;
private static int gResources;

public Text gText;
public Text bText;
public Text gRText;

void Start(){
	gScore = 0;	
        bScore = 0;	
        gResources = 50;
}
void Update(){
	if (gScore >= 500){
		print("Well done, you may now add 5 to your Epping points :)");
		//change scene to player wins
	}
	if (bScore >= 500){
		print("Game Over, have you tried being better?");
		//change scene to player loses
	}
    gText.text = " " + BlueFaction.AddGPoints;
    bText.text = " " + GreenFaction.AddBPoints;
    gRText.text = " " + ResourceTree.treeAddGPoints;
}
}
/*public void Reset(){
    gScore=0;
	bScore=0;
	gResources=50;

}*/