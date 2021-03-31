using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public static float v= .9000f;

    [SerializeField] GameObject balloonPrefab;
    
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn() {
        Instantiate(balloonPrefab, transform.position, transform.rotation);
    
    }

    
}
