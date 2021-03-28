using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;
    private Rigidbody2D rb;
    public float speed;
    Vector2 input;
    private float LastShoot;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        input.y = Input.GetAxis("Vertical");


		if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.25f)
		{
            Shoot();
            LastShoot = Time.time;
		}
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    
    }
    private void Shoot()
	{
        
        
      Instantiate(BulletPrefab, transform.position * 0.7f, Quaternion.identity);
        
	}
}
