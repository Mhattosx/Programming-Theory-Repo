using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stag : Animal
{
    private void Awake()
    {
        _statusGui = canvas.GetComponent<StatusGUI>();
        _statusGui.SetName("Stag");
        _statusGui.SetMaxhealth(100);
        _statusGui.SetHealth(100);;
    }
}
