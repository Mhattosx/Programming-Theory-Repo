using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoxController : MonoBehaviour
{
    private Fox _fox;
    private void Awake()
    {
        _fox = GetComponent<Fox>();
    }
}
