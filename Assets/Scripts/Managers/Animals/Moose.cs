using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moose : Animal
{
    private void Awake()
    {
        _statusGui = canvas.GetComponent<StatusGUI>();
        _statusGui.SetName("Moose");
        _statusGui.SetMaxhealth(120);
        _statusGui.SetHealth(120);;
    }
}
