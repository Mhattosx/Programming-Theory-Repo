using System;
using UnityEngine;
using UnityEngine.UI;


public enum AnimalType { Aggressive, Passive }
public class Animal : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;
    protected StatusGUI _statusGui;
}