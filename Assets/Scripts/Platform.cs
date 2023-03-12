using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Transform[] pointsPosition;
    [SerializeField] private float speedSet;
    private GameObject _player;
    private bool _wallActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move();
        }
        
    }

    public void Move()
    {
        foreach (Transform target in pointsPosition)
        {
            StartCoroutine(MoveToTarget(gameObject.transform,target.position,speedSet));
        }
        _player.GetComponent<PlayerMovement>().UpInput();
    }
    
    public IEnumerator MoveToTarget(Transform obj, Vector3 target, float speed)
    {
        while(obj.position != target  )
        {
            obj.position=Vector3.MoveTowards(obj.position, target, speed*Time.deltaTime);
            yield return null;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            _player = col.gameObject;
            Physics2D.IgnoreLayerCollision(3,7,true);
            _player.GetComponent<PlayerMovement>().DownInput();
            _player.transform.parent = gameObject.transform;
            Move();
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.GetComponent<PlayerMovement>())
        {
            Physics2D.IgnoreLayerCollision(3,7,false);
            col.transform.parent = null;
        }
    }
}
