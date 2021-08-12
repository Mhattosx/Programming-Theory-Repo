using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Hidle()
    {
        _animator.SetFloat("Speed_f",0);
    }

    public void Walk()
    {
        _animator.SetFloat("Speed_f",1);
    }
}
