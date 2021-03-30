using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBlue : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] Sprite[] balloonSprites;
    private int Vida = 1;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 1)];

        transform.position = new Vector3(Random.Range(-8.25f, 3.6f), transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(300, 500), 0);
        rb.AddForce(force);


    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TopWall")
        {
            Destroy(this.gameObject);
        }
    }
    public void Hit()
    {
        Vida = Vida - 2;
        if (Vida < 0) Destroy(gameObject);
    }
}
