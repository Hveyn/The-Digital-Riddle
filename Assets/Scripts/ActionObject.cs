using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionObject : Action
{
    

    public override void StartAction()
    {
        Destroy(gameObject);
    }
}
