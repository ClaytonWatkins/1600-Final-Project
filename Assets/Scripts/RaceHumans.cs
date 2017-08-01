using UnityEngine;
using System.Collections;

public class RaceHumans : MonoBehaviour {

    //PROPERTIES
    public int health = 300;
    public int speed = 15;
    public int damage = 20;
	public string size = "medium";
    //Blue Faction




    //FUNCTIONS
    //gather resources (+= 3) when not in combat
    public float regen = 1.5f;
    public int attackRange = 2;
    public int attackSpeed = 2;
    public int spottingRange = 30;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//if (!attack)
        {
            //perform TaskGatherResources
        }
           
                }
}
