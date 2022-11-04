using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadethrower : MonoBehaviour
{
    public GameObject grenadePrefab;
    public Transform MyCamera;

    public float throwForce;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            throwGrenade();
        }
    }

    private void throwGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, MyCamera.position, Quaternion.identity);
        Destroy(grenade, 4);

        Rigidbody rb = grenade.GetComponent<Rigidbody>();

        rb.AddForce(MyCamera.forward * throwForce, ForceMode.Impulse);
    }
}