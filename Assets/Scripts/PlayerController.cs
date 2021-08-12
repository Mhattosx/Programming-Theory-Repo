using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _speedRotate = 4f;

    private PlayerAnimation _playerAnimation;

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    void Update()
    {
        MovementHandler();
        RotateHandler();
    }

    private void MovementHandler()
    {
        var position = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (position != Vector3.zero)
        {
            _playerAnimation.Walk();
            transform.Translate(position * (_speed * Time.deltaTime));
        }
        else
        {
            _playerAnimation.Hidle();
        }
    }
    private void RotateHandler()
    {
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X")* _speedRotate, 0f);
        }
    }
}