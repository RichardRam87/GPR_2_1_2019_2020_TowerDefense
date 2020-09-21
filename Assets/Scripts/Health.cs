using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _startHealth = 3;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    public void TakeDamage(float dmg)
    {
        _currentHealth -= dmg;
        print("Ik krijg schade...");
        
        if (_currentHealth <= 0)
        {
            print("Ik ben dood");
        }
        
    }
}
