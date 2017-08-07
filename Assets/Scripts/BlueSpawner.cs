using UnityEngine;
using System.Collections;

public class BlueSpawner : MonoBehaviour {

public Transform[] spawnLocations;
public GameObject[] whatToSpawnPrefab;
public GameObject[] whatToSpawnClone;
public float repeatTime = 15f;

void Start(){
	InvokeRepeating("spawnBlue", 2f, repeatTime);
}
void spawnBlue(){
	whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
}
}