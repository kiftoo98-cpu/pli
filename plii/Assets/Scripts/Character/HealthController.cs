using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private Health _health;
    private HealthView _healthView;
    
    void Start()
    {
        _health = GetComponent<Health>();
        _healthView = GetComponent<HealthView>();
        _health.OnDamaged += HealthHandler;
    }

    private void HealthHandler(int newHealth, int maxhelth)
    {
        _healthView.ChangeBar(newHealth,maxhelth);
    }
    
    
}
