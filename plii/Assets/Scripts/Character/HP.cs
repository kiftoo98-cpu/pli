using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float _hp = 10;

    private void Update()
    {
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
