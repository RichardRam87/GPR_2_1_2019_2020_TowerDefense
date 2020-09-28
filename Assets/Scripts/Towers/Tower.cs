using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private EnemyInRangeChecker _rangeChecker;
    private Enemy _target;
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyInRangeChecker>();
    }

    void Update()
    {
        // als we niet kunnen aanvallen. Ga dan uit de update functie
        if (!CanAttack()) return;
        
        Attack();
    }
    
    private bool CanAttack()
    {
        _target = _rangeChecker.GetFirstEnemyInRange();
        return _target != null;
    }

    private void Attack()
    {
        Debug.Log("Ik val aan!");
    }
}
