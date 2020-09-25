using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTargetTower : Tower<Enemy>
{
    protected override bool CanAttack()
    {
        _target = _rangeChecker.GetFirstEnemyInRange();
        if (_target == null) return false;

        return true;
    }

    protected override void Attack()
    {
        print("Single target attack at: " + _target.name);
    }
}
