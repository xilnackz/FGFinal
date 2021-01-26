﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleGun_Fire : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;

    public Camera fpsCam;
    public ParticleSystem particle;
    public AudioSource fireSound;
    
    //Zoom
    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5;

    private bool isZoomed = false;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
        //Zoom
        if (Input.GetMouseButtonDown(1))
        {
            isZoomed = !isZoomed;
        }

        if (isZoomed)
        {
            fpsCam.fieldOfView = Mathf.Lerp(fpsCam.fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            fpsCam.fieldOfView = Mathf.Lerp(fpsCam.fieldOfView, normal, Time.deltaTime * smooth);
        }
    }

    void Shoot()
    {
        particle.Play();
        fireSound.Play();

        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            
            
        }
    }
}
