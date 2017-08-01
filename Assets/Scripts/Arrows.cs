using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour {

    public float damage = 15.0;
    private float target = GameObject;
 
 // Destroy bullet after collision, spawn an explosion prefab and send message to hit object
 
 void Start()
    {
        target = GameObject.FindWithTag("GreenFaction");
    }

   void OnCollisionEnter()
    {
        if GameObject.nameTag ("GreenFaction")
        // Apply damage to target object
        target.collider(damage, SendMessageOptions.DontRequireReceiver);

        // Destroy missile
        Destroy(gameObject);
        }