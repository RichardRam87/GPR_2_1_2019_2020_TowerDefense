using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{   
    // TODO: Healthbar object maken en koppelen aan UnityEvent
    public void UpdateHealthBar(Health health)
    {
        print("Mijn health is: " + health.CurrentHealth);
    }
}
