using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMO : MonoBehaviour
{
    public float slowdownFactor = 0.2f;
    public float slowdownLenght = 10f;
   
    public FirstPersonAIO pMovement;

    public ProjectileGunTutorial pgt;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            DoSlowmotion();
        }
        
        Time.timeScale += (1f / slowdownLenght) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
 
    public void DoSlowmotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .2f;
        
        pMovement.walkSpeed *= 2;
        pMovement.sprintSpeed *= 2;
        pgt.timeBetweenShooting = 0.05f;
    }
}
