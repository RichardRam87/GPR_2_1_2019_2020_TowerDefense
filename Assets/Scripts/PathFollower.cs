using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalthreshold = 0.1f;
    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(_target.position.x, transform.position.y, _target.position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);
        
        if (distance <= _arrivalthreshold)
        {
            print("Ik ben er!");
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);    
        }
    }
}
