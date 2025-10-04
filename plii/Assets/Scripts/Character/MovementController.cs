using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _jumpImpulse = 5f;
    private Rigidbody2D _rb;
    private KeyboardInputReceiver _inputReceiver;
    public bool IsGrounded;

    private void Awake()
    {
        _inputReceiver = GetComponent<KeyboardInputReceiver>();
        _rb = GetComponent<Rigidbody2D>();

    }
    
    
    void Update()
    {
        _rb.velocity = new Vector2(_inputReceiver.MoveX * _speed, _rb.velocity.y);
        if (_inputReceiver.MoveX > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1 ,1);
        }
        else if(_inputReceiver.MoveX < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else return;

        if (_inputReceiver.JumpPressed)
        {
            Debug.Log("нажали пробел");
        }

        if (IsGrounded && _inputReceiver.JumpPressed)
        {
            _rb.AddForce(Vector2.up * _jumpImpulse, ForceMode2D.Impulse);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = true;
            Debug.Log("Земли касаемся");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = false;
            Debug.Log("Земли не касаемся");
        }
    }
}
