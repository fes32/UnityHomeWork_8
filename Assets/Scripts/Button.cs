using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private Animator _animator;

    public void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        _animator.SetTrigger("Start");
    }
}