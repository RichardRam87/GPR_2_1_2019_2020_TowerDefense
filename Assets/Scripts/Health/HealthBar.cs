using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform _foreground = null;
    [SerializeField] private Canvas _rootCanvas = null;
    
    public void UpdateHealthBar(Health health)
    {
        if (health.GetNormalizedHealth() <= 0)
        {
            _rootCanvas.enabled = false;
            return;
        }
        _foreground.localScale = new Vector3(health.GetNormalizedHealth(), 1, 1);
    }
}
