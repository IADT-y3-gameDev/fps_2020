using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //variables that can be set in the Inspector    
    public GameObject spawn;
    public int amount = 1;
    public float delaySpawn = 1;
    

    private int getAmount;
    private float timer;
    private int spawned;


    public void Start()
    {
        Debug.Log("Spawner");
        ResetRound();
    }    
     
    public void ResetRound()
    {
      
        getAmount = amount;

    }

    void Update()
    {
        //Increase timer per frame.
        timer += Time.deltaTime;
        //Do the spawn if our timer is larger than the delay spawn we set.
        if (delaySpawn < timer)
        {
            //And we haven’t reached the spawn amount.
            if (spawned < getAmount)
            {
                //Reset our timer.
                timer = 0;
                spawned++;
                //cloning our enemies
                GameObject instance = Instantiate(spawn,transform);
                //remove the parent from the cloned enemies.
                instance.transform.parent = null;
            }
        }
    }

   
    //visualising the object of the Spawner
    private void OnDrawGizmos()
    {
        //Draw the wireframe mesh of what we intend to spawn in our editor.
        Gizmos.color = Color.red;
        if (spawn != null)
        {
            Gizmos.DrawWireMesh(spawn.GetComponent<MeshFilter>().sharedMesh, transform.position, spawn.transform.rotation, Vector3.one);
        }
    }
}

