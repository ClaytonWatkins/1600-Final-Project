using UnityEngine;
using System.Collections;

public class ClassMage : MonoBehaviour {

    //PROPERTIES
    //Armor (armor = armor * 1)
    public int cost = 20;
    public float moveSpeed = 4f;
    public Transform target;
    public float attackSpeed = 4;
    public float spottingRange = 60f;
    public Rigidbody projectile;
	public Transform Spawnpoint;
	public float shootSpeed = 50f;
    public int randomTarget;
    //public myTarget GameObject;
    //public myTargets GameObject.FindWithClass ("BlueFaction");

    //FUNCTIONS
    //Snipe from hidden
    void Start(){
        StartCoroutine(ShootArrows());
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
        possibleTargets = GameObject.FindGameObjectsWithTag("BlueFaction");
        if (possibleTargets.Length < 0){
            randomTarget = Random.Range(0, possibleTargets.Length);
            target = possibleTargets[randomTarget].transform;
        }return null;
    }
	void OnTriggerStay (Collider other)	{
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