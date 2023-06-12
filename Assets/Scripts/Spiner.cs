using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Button = UnityEngine.UI.Button;
using Random = UnityEngine.Random;

public class Spiner : MonoBehaviour
{
    public RectTransform spin;
    public Animator animator;
    [SerializeField] float reducer;

    public float multiplier = 1;

    private bool round1 = false;

    public bool isStopped = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Reset();
        }

        if (multiplier > 0)
        {
            spin.Rotate(Vector3.forward, 1 * multiplier);
        }
        else
        {
            isStopped = true;
            animator.enabled = true;
        }

        if (multiplier < 10 && !round1)
        {
            multiplier += 0.1f;
        }
        else
        {
            round1 = true;
        }

        if (round1 && multiplier > 0)
        {
            multiplier -= reducer;
        }
    }

    private void Reset()
    {
        multiplier = 1;
        reducer = Random.Range(0.01f, 0.5f);
        round1 = false;
        isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
