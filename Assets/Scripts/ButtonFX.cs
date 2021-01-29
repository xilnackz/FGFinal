using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
   
   public AudioSource Bhold;
   public AudioSource BClick;
   public AudioClip clickFx;
   public AudioClip hoverFx;

   public void HoverSound()
   {
      Bhold.PlayOneShot((hoverFx));
   }
   public void ClickSound()
   {
      BClick.PlayOneShot(clickFx);
   }
}

