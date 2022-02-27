using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
   public void getAnimatorDance()
   {
       this.GetComponent<Animator>().Play("Dance");
   }
   public void getAnimatorWalk()
   {
       this.GetComponent<Animator>().Play("Walk");
   }
}
