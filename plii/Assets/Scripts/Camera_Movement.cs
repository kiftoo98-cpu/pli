using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public Transform player; 
    public float speed = 5.0f; 
    public Vector3 Offset;



    void LateUpdate()
    {
        Vector3 _targetPosition = player.position + Offset;
        transform.position = Vector3.Lerp(transform.position, _targetPosition, speed * Time.deltaTime);
    }
}
