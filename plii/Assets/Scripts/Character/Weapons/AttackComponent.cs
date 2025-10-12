using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    [SerializeField] private float _cooldown = 0.35f;

    private IWeapon _weapon;
    private KeyboardInputReceiver _input;
    private bool canAttack = true;

    private void Awake()
    {
        _weapon = GetComponent<IWeapon>() ?? GetComponentInParent<IWeapon>();
        _input = GetComponentInParent<KeyboardInputReceiver>();
    }

    
    void Update()
    {
        if (!canAttack || _weapon == null || _input == null) return;

        if (_input.AttackPressed)
        {
            Debug.Log("нажата кнопка мыши");
            _weapon.Use();
            StartCoroutine(CooldownRoutine());
        }
    }

    private IEnumerator CooldownRoutine()
    {
        canAttack = false;
        yield return new WaitForSeconds(_cooldown);
        canAttack = true;
    }
}
