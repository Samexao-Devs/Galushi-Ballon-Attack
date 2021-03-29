using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;
    private Rigidbody2D rb;
    public float speed;
    Vector2 input;
    private float LastShoot;
    public Image barraDeVida;
    public static float vidaActual =10;
    public float vidaMaxima;
   
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
        //barraDeVida.fillAmount = vidaActual / vidaMaxima;
        
        vidaActual = vidaActual - Time.deltaTime;
        if (vidaActual < 0) Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    
    }
    private void Shoot()
	{
        Vector3 direction;
        if (transform.localScale.x == 2.9f) direction = Vector3.left;
        else direction = Vector3.left;
        GameObject bullet= Instantiate(BulletPrefab, transform.position + direction * 2.0f, Quaternion.identity);
        bullet.GetComponent<BulletScrpt>().SetDirection(direction);

       
    }
   
}
