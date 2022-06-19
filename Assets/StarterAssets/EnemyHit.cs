using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public GameObject _player;
    public float _forceHeight;       //êÅÇ´îÚÇŒÇ∑çÇÇ≥í≤êÆíl
    public float _forcePower;        //êÅÇ´îÚÇŒÇ∑ã≠Ç≥í≤êÆíl

    void Start()
    {
        _player = GameObject.Find("PlayerArmature");
        _forcePower = 50;
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (!collider.CompareTag("Enemy"))
        {
            return;
        }

        ThirdPersonController player = _player.GetComponent<ThirdPersonController>();
        
        Rigidbody otherRigitbody = collider.GetComponent<Rigidbody>();
        if (!otherRigitbody)
        {
            return;
        }

        Vector3 toVec = GetAngleVec(_player, collider.gameObject);
        toVec = toVec + new Vector3(0, _forceHeight, 0);
        otherRigitbody.AddForce(toVec * _forcePower, ForceMode.Impulse);
    }

    private Vector3 GetAngleVec(GameObject from, GameObject to)
    {
        Vector3 fromVec = new Vector3(from.transform.position.x, 0, from.transform.position.z);
        Vector3 toVec = new Vector3(to.transform.position.x, 0, to.transform.position.z);

        return Vector3.Normalize(toVec - fromVec);
    }
}
