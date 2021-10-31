using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject BulletPrefab;
    private Rigidbody2D rb;
    public float speed;
    public static Vector2 input;
    private float LastShoot;
    public Image barraDeVida;
    public static float vidaActual =10;
    public float vidaMaxima;
    public EdgeCollider2D nb;
    public Image textoGameOver;
    public AudioClip GameOver;
    public Button PauseButton;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
		
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NaveBottom")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        input.y = Input.GetAxis("Vertical");


		if (Input.GetKey(KeyCode.Mouse0) && Time.time > LastShoot + 0.25f)
		{
            Shoot();
            LastShoot = Time.time;
		}

        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        
        vidaActual = vidaActual - Time.deltaTime;
        if (vidaActual < 0) rb.gravityScale = 50 ;
        if (vidaActual < 0) nb.isTrigger = true;


        if (vidaActual < 0)
        {
            textoGameOver.gameObject.SetActive(true);
            PauseButton.gameObject.SetActive(false);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(GameOver);

        }

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
