using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    private Animator _animator;

    private int _animIDBlock;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        AssignAnimationIDs();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            _animator.SetBool(_animIDBlock, true);
        }
        else
        {
            _animator.SetBool(_animIDBlock, false);
        }
    }

    private void AssignAnimationIDs()
    {
        _animIDBlock = Animator.StringToHash("Block");
    }

}
