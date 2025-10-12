using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _range = 1.5f;
    [SerializeField] private float _radius = 0.1f;
    [SerializeField] private LayerMask _hitMask;
    [SerializeField] private Transform _firePoint;
    [SerializeField] private Transform _character;

    public void Use()
    {
        Vector3 origin = _firePoint ? _firePoint.position : transform.position;
        Vector2 dir = _character.right * Mathf.Sign(_character.localScale.x);
        RaycastHit2D hit = Physics2D.CircleCast(origin, _radius, dir, _range, _hitMask);
        Debug.DrawRay(origin, dir * _range, Color.red, 0.2f);
        if(hit.collider != null && hit.collider.TryGetComponent<IDamagable>(out var dmg))
        {
            dmg.TakeDamage(_damage, hit.point, hit.normal);
            Debug.Log("Прошел удар");
        }
    }

    public void Broke()
    {

    }
}
