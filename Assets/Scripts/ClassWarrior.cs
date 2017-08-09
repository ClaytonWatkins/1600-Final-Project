using UnityEngine;
using System.Collections;

public class ClassWarrior : MonoBehaviour {

    //PROPERTIES
    //Armor (armor = armor * 1)
    public int cost = 20;
    public float moveSpeed = 10f;
    public Transform target;
    public float attackSpeed = 5f;
    public float spottingRange = 35f;
    public float damage = 15f;
    public int randomTarget;
    public int randomResource;
    public int attackCooldown = 3;

    //FUNCTIONS
    //Snipe from hidden

    void Awake()
    {
        ResourceTree();
    }
    void Update() {
        if (target == null){
            ResourceTree();
        }
        else{
            transform.LookAt(target);
			transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
        }
    }
        IEnumerator ResourceTree(){
        GameObject[] resources;
        resources = GameObject.FindGameObjectsWithTag("ResourceTree");
        if (resources.Length > 0){
            randomResource = Random.Range(0, resources.Length);
            (target) = resources[randomResource].transform;
        }return null;
    }
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag("GreenFaction")){
            GetNewTarget();
		}
	}
        IEnumerator GetNewTarget(){
        GameObject[] possibleTargets;
        possibleTargets = GameObject.FindGameObjectsWithTag("GreenFaction");
        if (possibleTargets.Length < spottingRange){
            randomTarget = Random.Range(0, possibleTargets.Length);
            target = possibleTargets[randomTarget].transform;
        }return null;
    }
    void OnCollisionStay(Collision other){ 
        if (other.gameObject.CompareTag("GreenFaction"));
            DamageGreen();
    }
    IEnumerator DamageGreen(){
        yield return new WaitForSeconds(1);
            GreenFaction.TakeDamage(damage);
            }
    }