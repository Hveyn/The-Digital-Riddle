using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorButtons : MonoBehaviour
{
    [SerializeField] private ArrowMove parent;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject target = col.gameObject;
        if (target.GetComponent<ButtonRotate>())
        {
            
            ButtonRotate bt = target.GetComponent<ButtonRotate>();
            bt.Active(parent);
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        GameObject target = col.gameObject;
        if (target.GetComponent<ButtonRotate>())
        {
            ButtonRotate bt = target.GetComponent<ButtonRotate>();
            bt.DeActive();
        }
    }
}
