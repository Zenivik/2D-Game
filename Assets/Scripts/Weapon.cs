using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource audio;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("IsShooting", true);
            StartCoroutine(Shoot());
            audio.Play();
        }
    }

    IEnumerator Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("IsShooting", false);
    }
}
