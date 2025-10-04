using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable 
{
    void TakeDamage(int amount, Vector2 hitPoint, Vector2 hitNormal);
}
