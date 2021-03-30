using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonGreenSpawner : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, .90000f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(balloonPrefab2, transform.position, transform.rotation);

    }
}
