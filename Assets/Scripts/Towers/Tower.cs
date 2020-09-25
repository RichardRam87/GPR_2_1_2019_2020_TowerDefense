using UnityEngine;

[RequireComponent(typeof(EnemyInRangeChecker))]
public abstract class Tower<T> : MonoBehaviour
{
    protected EnemyInRangeChecker _rangeChecker;

    protected T _target;

    protected abstract bool CanAttack();
    protected abstract void Attack();
    private void Awake()
    {
        _rangeChecker = GetComponent<EnemyInRangeChecker>();
    }

    private void Update()
    {
        if (CanAttack())
            Attack();
    }
}
