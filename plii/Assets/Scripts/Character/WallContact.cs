using UnityEngine;

public class WallContact : MonoBehaviour
{
    [SerializeField] private float _lookDistance = 3f;
    [SerializeField] private LayerMask _layerMask;

    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] public float _force;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Vector2 direction = Vector2.right * transform.localScale.x;
        //Debug.DrawRay(transform.position, direction * _lookDistance, Color.red);
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, _lookDistance , _layerMask);
        //if (hit.collider.tag != null) 
        //{
        //    Debug.Log("Ray hit: " + hit.collider.name);
        //    _rb.AddForce((-direction + Vector2.up) * _force, ForceMode2D.Impulse);
        //}
        
        
            
        
    }
}
