using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInputReceiver : MonoBehaviour
{
    private const string HorizontalAxisName = "Horizontal";
    public float MoveX {  get; private set; }
    public bool JumpPressed { get; private set; }
    public bool AttackPressed { get; private set; }


    private void Update()
    {
        float HorizontalInput = Input.GetAxis(HorizontalAxisName);

        MoveX = HorizontalInput;

        JumpPressed = Input.GetButtonDown("Jump");

        AttackPressed = Input.GetMouseButtonDown(0);
    }
}
