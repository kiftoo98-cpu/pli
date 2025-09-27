using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Hit : MonoBehaviour
{
    

    void Damage(float damage)
    {
        gameObject.GetComponent<HP>()._hp -= damage;

    }
    


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Damage(1);
            Debug.Log(gameObject.GetComponent<HP>()._hp);
        }
    }
}
