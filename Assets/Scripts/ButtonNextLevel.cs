using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNextLevel : Action
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    public override void StartAction()
    {
        gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            Debug.Log("След уровень");
        }
    }
}
