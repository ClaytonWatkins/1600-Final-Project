using UnityEngine;
using System.Collections;

public class ClassArcher : MonoBehaviour {

    //PROPERTIES
    //Armor (armor = armor * 1)
    public float moveSpeed = 5f;
    public Transform target;
    public float attackRange = 2f;
    public float spottingRange = 35f;
    public Rigidbody projectile;
	public Transform Spawnpoint;
	public float shootSpeed = 40f;
    public int coolDown = 3;
    

    //FUNCTIONS
    //Snipe from hidden
    

    void fixedUpdate()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        
        if (target == null){
            target = other.gameObject.nameTag("GreenFaction");             
        }            

        if (dist >= spottingRange){
			transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
        }/*
    }
    void OnTriggerStay (Collider target)
    {*/
        if (dist <= spottingRange && WaitForSeconds >= coolDown);
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);
			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
	    }
}