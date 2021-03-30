using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour

{
    
    [SerializeField] GameObject balloonPrefab;
    
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, .9000f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        Instantiate(balloonPrefab, transform.position, transform.rotation);
    
    }

    
}
