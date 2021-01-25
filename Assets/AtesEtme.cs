using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    RaycastHit hit;
    public GameObject RayPoint;

    public bool CanFire;

    float gunTimer;
    public float gunCooldown;
    public ParticleSystem MuzzleFlash;

    AudioSource SesKaynak;
    public AudioClip FireSound;

    public float range;
    void Start()
    {
        SesKaynak = GetComponent<AudioSource>();  
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && CanFire == true && Time.time > gunTimer)
        {
            Fire();
            gunTimer = Time.time + gunCooldown;
        } 
    }
    void Fire() 
    {
        if (Physics.Raycast(RayPoint.transform.position, RayPoint.transform.forward, out hit, range))
        {
            MuzzleFlash.Play();
            SesKaynak.Play();

            SesKaynak.clip = FireSound;

            Debug.Log(hit.transform.name);


        }


    }

}