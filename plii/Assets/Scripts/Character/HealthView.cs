using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private Image _bar;

    public void ChangeBar(float value, float maxhealth)
    {
        float val = value/maxhealth;
        _bar.fillAmount = val;
        Debug.Log(val);
    }
}
