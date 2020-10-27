using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _damageAmount;

    private PathFollower _pathFollower;
    private Health _health;

    private void Awake()
    {
        _pathFollower = GetComponent<PathFollower>();
        _health = GetComponent<Health>();
    }

    void Start()
    {
        SetupEnemy();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _health.TakeDamage(1);
        }
    }

    private void SetupEnemy()
    {
        Health playerHealth = GameObject.FindWithTag("PlayerBase").GetComponent<Health>();
        Waypoint[] waypoints = FindObjectsOfType<Waypoint>().OrderBy(wp => wp.gameObject.name).ToArray();
        
        _pathFollower.OnPathComplete.AddListener(() => playerHealth.TakeDamage(_damageAmount));
        _pathFollower.SetPath(waypoints);
    }
}
