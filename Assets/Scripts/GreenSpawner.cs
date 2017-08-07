using UnityEngine;
using System.Collections;

public class GreenSpawner : MonoBehaviour {

public Transform[] spawnLocations;
public GameObject[] whatToSpawnPrefab;
public GameObject[] whatToSpawnClone;
public static int useResources;

public void spawnBerzerker(){
	if (ResourceUI.GetComponent<gResources>() >= 25){
	whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	useResources =+ (-25);
}
}
public void spawnMage(){
	if (ResourceUI.GetComponent<gRText>() >= 25){
	whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	useResources += (-25);
}
}
}