using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Image _bar;
    private Health _health;
    
    void Start()
    {
        _health = GetComponent<Health>();
    }

    
    void Update()
    {
        
    }
    public void ChangeBar(float value, float maxhealth)
    {
        float val = value/maxhealth;
        _bar.fillAmount = val;
        Debug.Log(val);
    }
}
