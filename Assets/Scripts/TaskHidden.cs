using UnityEngine;
using System.Collections;

public class TaskHidden : MonoBehaviour {

        public Rigidbody projectile;
        public float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	if OnTriggerStay(Collider enemy);{
     void CheckForMob();
    {
        var targets: GameObject[];
        var target: GameObject;
        targets = gameObject.FindGameObjectsWithTag("Enemy");
    for(var primarytarget in targets)
        {
            var primtargetdistance : float = Vector3.Distance(transform.position, primarytarget.transform.position);

            if (primtargetdistance <= 5)
            {
                target = primarytarget.transform;
                break;
            }
        }
        transform.GetComponent(meleecombat).target = target;
    }
      if (Input.GetButtonDown("fire1"))
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile,
                                                               transform.position,
                                                               transform.rotation)
                    as Rigidbody;

                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

            }
        }
    }

}
    // Update is called once per frame
    void Update () {
	
	}
}
