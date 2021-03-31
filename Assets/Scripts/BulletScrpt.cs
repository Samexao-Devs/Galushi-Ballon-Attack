
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScrpt : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float Speed;
    private Vector2 Direction;
    public AudioClip Sound;
    public AudioClip SoundExploit;
    private int difficulty=100;


    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }
    public void SetDirection(Vector2 direction)
	{
        Direction = direction;
	}
    public void DestroyBullet()
	{
        Destroy(gameObject);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(SoundExploit);
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        Balloon ballon = collision.GetComponent<Balloon>();
        BalloonBlue ballonb = collision.GetComponent<BalloonBlue>();
        BalloonGreen ballong = collision.GetComponent<BalloonGreen>();


        if (ScoreScript.scoreValue > difficulty)
        {
            Balloon.x += 1;
            Balloon.y += 1;
            BalloonBlue.x += 1;
            BalloonBlue.y += 1;
            BalloonGreen.x += 1;
            BalloonGreen.y += 1;
            BalloonSpawner.v += .10f;
            BalloonRespawnBlue.v += 0.25f;
            BalloonGreenSpawner.v += .10f;
            difficulty += 300;
           

        }
        if (ballon != null)
        {
            ballon.Hit();
            ScoreScript.scoreValue += 10;
            if(PlayerController.vidaActual<10) PlayerController.vidaActual += 1;
        }
        DestroyBullet();

        if (ballonb != null)
        {
            ballonb.Hit();
            ScoreScript.scoreValue += 30;
            if (PlayerController.vidaActual < 10) PlayerController.vidaActual += 1;
        }
        DestroyBullet();

        if (ballong != null)
        {
            ballong.Hit(); 
            ScoreScript.scoreValue += 10;
            if (PlayerController.vidaActual < 10) PlayerController.vidaActual += 1;
        }
        DestroyBullet();
    }
   
}
