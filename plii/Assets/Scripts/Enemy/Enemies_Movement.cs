using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Movement : MonoBehaviour
{
    [SerializeField] public Vector2[] patrolPoints; 
    private int currentPatrolIndex = 0;
    public float speed = 3f; 

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPatrolIndex], speed * Time.deltaTime);

        
        if (Vector2.Distance(transform.position, patrolPoints[currentPatrolIndex]) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length; 
        }
    }

}
