using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusGUI : MonoBehaviour
{
    [SerializeField] private Text Name;
    [SerializeField] private Slider Health;
    private GameObject _target;
    void Start()
    {
        _target = GameObject.Find("Player");
    }

    public void SetMaxhealth(int value) => Health.maxValue = value;
    public int GetMaxHealth() => (int)Health.maxValue;
    public void SetHealth(int value) => Health.value = value;
    public int GetHealth() => (int) Health.value;
    
    public void SetName(string _name) => Name.text = _name; 
    public string GetName() => Name.text;

    void Update()
    {
        transform.LookAt(_target.transform);
    }
}
