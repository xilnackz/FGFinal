using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.PostProcessing;

public class SlowMotion : MonoBehaviour {
    

   public float currentAmount = 0f;
   public float maxAmount = 7.8f;

    public FirstPersonAIO pMovement;

    public ProjectileGunTutorial pgt;

    public AudioSource slomoSound;

    public PostProcessVolume PPVolume;
    
// Use this for initialization
    void Start ()
    {
        slomoSound = GetComponent<AudioSource>();
    }
    

// Update is called once per frame
    void Update () {

        if(Input.GetKeyDown (KeyCode.F))
        {
            

            
            if (Time.timeScale >= 1.0f)
            {
                Time.timeScale = 0.2f;
                pMovement.walkSpeed =8;
                pMovement.sprintSpeed =16;
                pgt.timeBetweenShooting = 0.05f;
                slomoSound.Play();
                PPVolume.enabled = true;
            }
            else
            {
                
                pMovement.walkSpeed = 4;
                pMovement.sprintSpeed = 8;
                pgt.timeBetweenShooting = 0.1f;
                Time.timeScale = 1.0f;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                PPVolume.enabled = true;
                
            }
        }
        if (Time.timeScale >= 1.0f)
        {
                
            pMovement.walkSpeed = 4;
            pMovement.sprintSpeed = 8;
            pgt.timeBetweenShooting = 0.1f;
            PPVolume.enabled = false;

        }

        if(Time.timeScale == 0.2f){

            currentAmount += Time.unscaledDeltaTime;
        }

        if(currentAmount >= maxAmount)
        {

            currentAmount = 0f;
            Time.timeScale = 1.0f;

        }

    }
}