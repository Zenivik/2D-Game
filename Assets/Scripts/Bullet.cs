using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20;
    public int damage = 40;

    public Rigidbody2D rb;
    public GameObject impactEffectPrefab;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impactEffectPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
