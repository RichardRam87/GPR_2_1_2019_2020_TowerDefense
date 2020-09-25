﻿using UnityEngine;
using UnityEngine.Events;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private Waypoint[] _waypoints;

    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalthreshold = 0.1f;

    [SerializeField] private UnityEvent _OnPathComplete;
    public UnityEvent OnPathComplete => _OnPathComplete;

    private int _currentWaypointIndex;

    private void Start()
    {
        _currentWaypointIndex = 0;
    }

    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(_waypoints[_currentWaypointIndex].Position.x,
            transform.position.y, _waypoints[_currentWaypointIndex].Position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);

        if (distance <= _arrivalthreshold)
        {
            if (_currentWaypointIndex == _waypoints.Length - 1)
            {
                print("Ik ben bij het eindpunt");
                _OnPathComplete?.Invoke();
            }
            else
            {
                _currentWaypointIndex++;
            }
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }

    public void SetPath(Waypoint[] waypoints)
    {
        _waypoints = waypoints;
    }
}