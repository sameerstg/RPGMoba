using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    PlaneRaycaster prc;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        prc = GetComponent<PlaneRaycaster>();
    }
    private void Start()
    {
        prc = GetComponentInChildren<PlaneRaycaster>();
        InputSystem.DelegateAction leftclickAction = prc.leftclickAction;
        InputSystem._instance.leftClickActions.Add(leftclickAction);
        InputSystem._instance.leftClickActions.Add(Move);
    }


    void Move()
    {
        rb.AddForce((prc.leftClickedPosition - transform.position) * speed*Time.deltaTime,ForceMode.Impulse);
    }
}
