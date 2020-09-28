using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;

    private void Awake()
    {
        _waypoints = GameObject.FindObjectsOfType<Waypoint>();
        /*Array.Sort(_waypoints);
        _waypoints.ToArray().so*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
