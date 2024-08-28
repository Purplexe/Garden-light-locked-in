using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{

    private Transform playerTransform;
    [SerializeField] private float detection;
    public ParticleSystem particle;


    
   // Start is called before the first frame update
   // get the player
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
    
}

    private void Update()
    {
        if (playerTransform != null)
        {
            // If distance to player < the defined detection radius
            float distance = Vector3.Distance(transform.position, playerTransform.position);
            if (distance <= detection) 
            {
                // Emit those particles
                print("emitting");
                var em = particle.emission;
                em.enabled = true;
            }
        }
       
    }
   
}


