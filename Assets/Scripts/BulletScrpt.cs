using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScrpt : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float Speed;
    private Vector2 Direction;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Vector2.left * Speed;
    }
    public void SetDirection(Vector2 direction)
	{
        Direction = direction;
	}
    public void DestroyBullet()
	{
        Destroy(gameObject);
	}
}
