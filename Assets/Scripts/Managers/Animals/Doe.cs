using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doe : Animal
{
    private void Awake()
    {
        _statusGui = canvas.GetComponent<StatusGUI>();
        _statusGui.SetName("Doe");
        _statusGui.SetMaxhealth(80);
        _statusGui.SetHealth(80);;
    }
}
