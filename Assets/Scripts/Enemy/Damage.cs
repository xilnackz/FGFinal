using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   
public class Damage : MonoBehaviour
{
    public int health = 100;
    void OnTriggerEnter(Collider collider)
    {
       
        if (collider.gameObject.tag == "Bullet")
        {
            health = health - 20;
        }
       
       
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
