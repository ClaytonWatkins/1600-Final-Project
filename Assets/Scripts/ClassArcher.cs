using UnityEngine;
using System.Collections;

public class ClassArcher : MonoBehaviour {

    //PROPERTIES
    //Armor (armor = armor * 1)
    public int cost = 30;
    public float moveSpeed = 5f;
    public Transform target;
    public float attackSpeed = 3;
    public float spottingRange = 75f;
    public Rigidbody projectile;
	public Transform Spawnpoint;
	public float shootSpeed = 40f;
    public int randomTarget;

    //FUNCTIONS
    //Snipe from hidden
    void Awake()
    {
        GetNewTarget();
    }
    void Update() {
        if (target == null){
            GetNewTarget();
        }
        else{
            transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
        }
    }
        IEnumerator GetNewTarget(){
        GameObject[] possibleTargets;
        possibleTargets = GameObject.FindGameObjectsWithTag("GreenFaction");
        if (possibleTargets.Length < 75){
            randomTarget = Random.Range(0, possibleTargets.Length);
            target = possibleTargets[randomTarget].transform;
        }return null; //patrol
    }
	void OnCollisionStay (Collision other)	
    {
		while (target != null){            
            ShootArrows();
        }
    }
        IEnumerator ShootArrows(){
            yield return new WaitForSeconds(attackSpeed);
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);
	        clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
        }
}