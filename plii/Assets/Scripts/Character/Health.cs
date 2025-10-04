using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamagable
{
    [SerializeField] private int _maxHealth = 5;

    public int Current {  get; private set; }

    public UnityEvent OnDeath;
    public UnityEvent<int> OnDamaged;

    private void Awake()
    {
        Current = _maxHealth;
    }

    public void TakeDamage(int amount, Vector2 hitPoint, Vector2 hitNormal)
    {
        if(Current <= 0) return;
        Current -= Mathf.Max(1, amount);
        OnDamaged?.Invoke(Current);
        if(Current<= 0)
        {
            OnDeath?.Invoke();
        }
    }

    
}
