using UnityEngine;
using System.Collections;

public class SlowMotion : MonoBehaviour {

   public float currentAmount = 0f;
   public float maxAmount = 10f;

    public FirstPersonAIO pMovement;

    public ProjectileGunTutorial pgt;
// Use this for initialization
    void Start () {
    }
    

// Update is called once per frame
    void FixedUpdate () {

        if(Input.GetKeyDown ("z")){

            if (Time.timeScale == 1.0f)
            {     
                pMovement.walkSpeed *= 2;
                pMovement.sprintSpeed *= 2;
                pgt.timeBetweenShooting = 0.05f;
                Time.timeScale = 0.2f;
                
            }
            else
            {   
                pMovement.walkSpeed /= 2;
                pMovement.sprintSpeed /= 2;
                pgt.timeBetweenShooting = 0.1f;
                Time.timeScale = 1.0f;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
            }
        }


        if(Time.timeScale == 0.2f){

            currentAmount += Time.deltaTime;
        }

        if(currentAmount >= maxAmount){

            currentAmount = 0f;
            Time.timeScale = 1.0f;

        }

    }
}