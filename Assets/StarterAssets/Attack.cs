using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator _animator;

    private Collider _rightHandCollider;

    private int _animIDBoxing;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        AssignAnimationIDs();

        _rightHandCollider = GameObject.Find("playerRightHand").GetComponent<SphereCollider>();
        ColliderReset();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetBool(_animIDBoxing, false);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _rightHandCollider.enabled = true;
            _animator.SetBool(_animIDBoxing, true);

            Invoke("ColliderReset", 0.3f);
        }
    }

    private void AssignAnimationIDs()
    {
        _animIDBoxing = Animator.StringToHash("Boxing");
    }

    private void ColliderReset()
    {
        _rightHandCollider.enabled = false;
    }
}
