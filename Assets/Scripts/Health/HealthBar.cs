using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform _foreground = null;

    public void UpdateHealthBar(Health health)
    {
        Vector3 newScale = new Vector3(health.GetNormalizedHealth(), 1, 1);
        _foreground.localScale = newScale;
    }
}
