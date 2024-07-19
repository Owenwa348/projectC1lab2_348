using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    // This script launches a projectile prefab by instantiating it at the position
    // of the GameObject on which it is placed, then then setting the velocity
    // in the forward direction of the same GameObject.

[SerializeField] private AudioClip sndNewDamage;
[SerializeField] private AudioClip sndCrashWarning;
[SerializeField] private AudioClip sndHasDamageWarning;
[SerializeField] private AudioClip sndFueldLow;
    public Rigidbody Projectile;
    public float speed = 4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody p = Instantiate(Projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
        }
    }
}