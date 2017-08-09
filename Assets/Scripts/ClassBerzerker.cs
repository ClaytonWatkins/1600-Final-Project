using UnityEngine;
using System.Collections;

public class ClassBerzerker : MonoBehaviour {

    //PROPERTIES
    //Armor (armor = armor * 1)
    public int cost = 30;
    public float moveSpeed = 15f;
    public Transform target;
    public float attackSpeed = 5f;
    public float spottingRange = 35f;
    public float damage = 20f;
    public int randomTarget;
    public int randomResource;
    public int attackCooldown = 4;

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
		if (other.gameObject.CompareTag("BlueFaction")){
            GetNewTarget();
		}
	}

        IEnumerator GetNewTarget(){
        GameObject[] possibleTargets;
        possibleTargets = GameObject.FindGameObjectsWithTag("BlueFaction");
        if (possibleTargets.Length < spottingRange){
            randomTarget = Random.Range(0, possibleTargets.Length);
            target = possibleTargets[randomTarget].transform;
        }return null;
    }

    void OnCollisionStay (Collision other){ 
        if (other.gameObject.CompareTag("BlueFaction"));
            DamageBlue();
    }
    IEnumerator DamageBlue(){
        yield return new WaitForSeconds(3);
            BlueFaction.TakeDamage(damage);
            }
    }