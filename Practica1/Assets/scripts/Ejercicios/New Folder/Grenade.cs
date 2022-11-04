using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float timeToExplode;

    private bool hasExplode;

    public GameObject explsionParticlesPrefab;

    public float explosionRadius = 2;

    public float explosionForce = 10000;

    private void Update()
    {
        timeToExplode -= Time.deltaTime;

        if (timeToExplode < 0 && !hasExplode)
        {
            Explode();
            hasExplode = true;
        }
    }

    private void Explode()
    {
        GameObject explosionEffect = Instantiate(explsionParticlesPrefab, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
    }
}