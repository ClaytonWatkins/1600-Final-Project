using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResourceUI : MonoBehaviour {

private static int gScore;
private static int bScore;
private static int gResources;

public Transform[] spawnLocations;
public GameObject[] whatToSpawnPrefab;
public GameObject[] whatToSpawnClone;

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
		SceneManager.LoadScene (2);
	}
	if (bScore >= 500){
		SceneManager.LoadScene (3);
	}
	gText.text = gScore.ToString();
    bText.text = bScore.ToString();
    gRText.text = gResources.ToString();
}

public static void AddGPoints(int GPoints){
	gScore += GPoints;
	}

public static void AddBPoints(int BPoints){
	bScore += BPoints;
	}

public static void treeAddGPoints(int RPoints){
	gResources += RPoints;
	}


public void spawnBerzerker(){
	if (gResources >= 25){
	whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	gResources -= 25;}
	else{
		print("not enough resources.");
	}
}

public void spawnMage(){
	if (gResources >= 25){
	whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	gResources -= 25;}
	else{
		print("not enough resources.");
	}
}
}