using UnityEngine;

public class MultiTargetTower : Tower<Enemy[]>
{
    protected override bool CanAttack()
    {
        _target = _rangeChecker.GetAllEnemiesInRange();
        if (_target == null || _target.Length < 1) return false;

        return true;
    }

    protected override void Attack()
    {
        foreach (Enemy enemy in _target)
        {
            print("multi target attack at: " + enemy.name);
        }
    }
}
