using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{

    private Transform playerTransform;
    [SerializeField] private float detection;
    public ParticleSystem particle;


    // Start is called before the first frame update
    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
    
}

    private void Update()
    {
        if (playerTransform != null)
        {
            float distance = Vector3.Distance(transform.position, playerTransform.position);
            if (distance <= detection) 
            {
                print("emitting");
                var em = particle.emission;
                em.enabled = true;
            }
        }
        print(playerTransform.position);
    }
   
}


