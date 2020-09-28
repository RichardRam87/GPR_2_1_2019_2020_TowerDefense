using System;
using UnityEngine;
using UnityEngine.Events;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalthreshold = 0.1f;

    [SerializeField] private UnityEvent _OnPathComplete;
    public UnityEvent OnPathComplete => _OnPathComplete;

    //private int _currentWaypointIndex;
    private Path _path;
    private Waypoint _currentWaypoint;
    
    private void Start()
    {
        _path = FindObjectOfType<Path>();
        _currentWaypoint = _path.GetPathStart();
    }

    private void Update()
    {
        Vector3 heightOffsetPosition = new Vector3(_currentWaypoint.Position.x,
            transform.position.y, _currentWaypoint.Position.z);
        float distance = Vector3.Distance(transform.position, heightOffsetPosition);

        if (distance <= _arrivalthreshold)
        {
            if (_currentWaypoint == _path.GetPathEnd())
            {
                print("Ik ben bij het eindpunt");
                _OnPathComplete?.Invoke();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
            }
        }
        else
        {
            transform.LookAt(heightOffsetPosition);
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}