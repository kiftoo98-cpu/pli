using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPLayer : MonoBehaviour
{
    private Health _health;
    [SerializeField] private int _damage = -1;
    void Start()
    {
        _health = GetComponent<Health>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("kosnulsya vraga");
            _health.ChangeHealth(_damage);
        }
    }
    

    
}
