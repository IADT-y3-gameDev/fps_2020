using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int hitNumber;

    // CollisionHandler. Other is a collision object it collides with
    void OnCollisionEnter(Collision other)
    {
        	if(other.transform.CompareTag("bullet")) 
            {
                hitNumber++;
            }

            if (hitNumber == 3) 
            {
                Debug.Log("Zombie dead!");
                Destroy(gameObject);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
