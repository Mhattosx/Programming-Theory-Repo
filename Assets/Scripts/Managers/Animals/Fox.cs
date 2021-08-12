using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fox : Animal
{
    private void Awake()
    {
        _statusGui = canvas.GetComponent<StatusGUI>();
        _statusGui.SetName("Fox");
        _statusGui.SetMaxhealth(50);
        _statusGui.SetHealth(50);;
    }
}
