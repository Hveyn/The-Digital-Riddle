using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
   [SerializeField] protected bool toRight;

   protected ArrowMove _arrow;
   
   private void OnMouseDown()
   {

      if (_arrow != null)
      {
         _arrow.RotationTo(toRight);
      }
   }
   
   public void Active(ArrowMove arrow)
   {
      Debug.Log("Active");
      _arrow = arrow;
   }

   public void DeActive()
   {
      Debug.Log("Deactive");
      _arrow = null;
   }
}
