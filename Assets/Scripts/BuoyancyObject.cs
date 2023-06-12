using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BuoyancyObject : MonoBehaviour
{
    public float underWaterDrag = 3f;

    public float underWaterAngularDrag = 1f;

    public float airDrag = 0f;

    public float airAngularDrag = 0.05f;

    public float floatingPower = 15f;
    
    public float waterHeight = 1f;

    private Rigidbody _objRigidbody;

    private bool _underwater;

    private void Start()
    {
        _objRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var diff = transform.position.y - waterHeight;
        if (diff < 0)
        {
            _objRigidbody.AddForceAtPosition(Vector3.up * (floatingPower * Mathf.Abs(diff)), transform.position, ForceMode.Force);
            if (_underwater) return;
            _underwater = true;
            SwitchState(true);
        }
        else if (_underwater)
        {
            _underwater = false;
            SwitchState(false);
        }
    }

    private void SwitchState(bool isUnderwater)
    {
        if (!isUnderwater)
        {
            _objRigidbody.drag = underWaterDrag;
            _objRigidbody.angularDrag = underWaterAngularDrag;
        }
        else
        {
            _objRigidbody.drag = airDrag;
            _objRigidbody.angularDrag = airAngularDrag;
        }
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
