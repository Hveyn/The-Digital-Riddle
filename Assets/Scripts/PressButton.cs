using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    [SerializeField] private Action[] actionsObject;
    private bool _moveBut;
    private GameObject _arrowButton;
    
    private void RunActions()
    {
        foreach (Action actionObject in actionsObject)
        {
            actionObject.StartAction();
        }
    }

    private void Update()
    {
        if (_moveBut)
        {
            _arrowButton.transform.position = Vector2.MoveTowards(
                _arrowButton.transform.position,
                transform.position, 0.05f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject other = col.gameObject;
        if (other.GetComponent<ArrowMove>())
        {
            _arrowButton = other;
            
            other.GetComponent<ArrowMove>().Stop();
            _moveBut = true;
            
            RunActions();
        }
    }
}
