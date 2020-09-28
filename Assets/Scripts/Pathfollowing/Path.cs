using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Path : MonoBehaviour
{
    private Waypoint[] _waypoints;

    private void Awake()
    {
        _waypoints = FindObjectsOfType<Waypoint>().OrderBy(wp => wp.gameObject.name).ToArray();
    }

    public Waypoint GetPathStart()
    {
        return _waypoints[0];
    }

    public Waypoint GetPathEnd()
    {
        return _waypoints[_waypoints.Length - 1];
    }

    public Waypoint GetNextWaypoint(Waypoint currentWaypoint)
    {
        Waypoint nextWaypoint = null;
        for (int i = 0; i < _waypoints.Length; i++)
        {
            if (_waypoints[i] == currentWaypoint)
            {
                nextWaypoint = _waypoints[i + 1];
            }
        }
        return nextWaypoint;
    }
}
