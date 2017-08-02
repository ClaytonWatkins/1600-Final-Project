using UnityEngine;
using System.Collections;

public class RaceTrolls : MonoBehaviour {

    //PROPERTIES
    public int resources = 30;
    public int health = 400;
    public int speed = 10;
    public int damage = 25;
	public string size = "large";
    public int spawnPoint;

    //Green Faction

    //FUNCTIONS
    //hide when not in combat
    public float regen = 4.5f;
    public float attackRange = 2.5f;
    public int attackSpeed = 3;
    public int spottingRange = 30;

    public Transform target;

    /*void Start()
    {
        target = GameObject.Find("BlueFaction").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, Time.deltaTime);
         = Vector3.Distance(target.position, transform.position);
        }*/
    
	// Update is called once per frame

    
        //Scan spottingRange for Faction and Resources
        //if (!attack)
        //perform TaskHidden

        //Opposing faction located 

        //if <= attackRange
        //Attack
        //else 
        //Move to <= attackRange

        //Faction located 

        //if under attack
        //move to attackRange and attack/heal
        //else
        //null

       
     
     /*if(lookAtTarget )
     {
        var player = GameObject.FindWithTag("Player");
var rotate = Quaternion.LookRotation(closestEnemy.transform.position - transform.position);
transform.rotation = Quaternion.Slerp(transform.rotation, rotate, Time.deltaTime* turnSpeed);
     */}