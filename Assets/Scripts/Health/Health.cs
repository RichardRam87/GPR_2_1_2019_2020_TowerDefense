using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [Serializable]
    public class OnTakeDamageEvent : UnityEvent<Health> {}
    [Serializable]
    public class OnDeathEvent : UnityEvent<Health> {}

    [SerializeField] private float _startHealth = 3;
    
    public OnTakeDamageEvent OnTakeDamage;
    public OnDeathEvent OnDeath;
    

    private float _currentHealth;
    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    // Called from UnityEvent
    public void TakeDamage(float dmg = 1f)
    {
        _currentHealth = Mathf.Max(_currentHealth - dmg, 0);
        OnTakeDamage?.Invoke(this);
        
        if (_currentHealth <= 0)
        {
            print("Ik ben dood");
            OnDeath?.Invoke(this);
        }
    }

    public float GetNormalizedHealth()
    {
        return _currentHealth / _startHealth;
    }
}
