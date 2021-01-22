using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silah_alma : MonoBehaviour
{
    public Transform Player;
    public GameObject Silah;
    public GameObject Smg;
    public GameObject flash;
    public bool mesafe;
    
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < 5)
        {
            mesafe = true;
        }
        else
        {
            mesafe = false;
        }

        if (mesafe == true && Input.GetKeyDown(KeyCode.E))
        {
            Silah.SetActive(true);
            mesafe = false;
            Destroy(gameObject);
            Smg.SetActive(false);
            flash.SetActive(false);
        }
         
    }
}
