using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorPlayer : MonoBehaviour
{
    [SerializeField] private ArrowMove parent;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject target = col.gameObject;
        if (target.GetComponent<PlayerMovement>() != null)
        {
            parent.SetMove(true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        GameObject target = col.gameObject;
        if (target.GetComponent<PlayerMovement>() != null)
        {
            parent.SetMove(false);
        }
    }
}
