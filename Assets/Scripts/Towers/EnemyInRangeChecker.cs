using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInRangeChecker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _layer;
    
    public Enemy GetFirstEnemyInRange()
    {
        var cols = Physics.OverlapSphere(transform.position, _radius, _layer);
        if (cols.Length < 1) return null;

        return cols[0].GetComponent<Enemy>();
    }

    public Enemy[] GetAllEnemiesInRange()
    {
        var cols = Physics.OverlapSphere(transform.position, _radius, _layer);
        if (cols.Length < 1) return null;
        
        List<Enemy> enemies = new List<Enemy>();
        for (int i = 0; i < cols.Length; i++)
        {
            enemies.Add(cols[i].GetComponent<Enemy>());
        }

        return enemies.ToArray();
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, _radius);
    }
}
