using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    protected EnemyInRangeChecker _rangeChecker;

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

    protected virtual bool CanAttack()
    {
        return false;
    }

    protected virtual void Attack() { }
}
