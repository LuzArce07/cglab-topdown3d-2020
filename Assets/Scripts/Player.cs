﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField]
    float moveSpeed;

    Animator anim;

    [SerializeField]
    GameObject weapon;

    void Awake() 
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        weaponVisible(false);
    }
    

    void Update()
    {
        transform.Translate(Axis.normalized.magnitude * Vector3.forward * moveSpeed * Time.deltaTime);

        if(Axis != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(Axis);
        }
        anim.SetFloat("move", Mathf.Abs(Axis.normalized.magnitude));

    }

    Vector3 Axis
    {
        get => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
    public Animator Anim { get => anim; }

    public void weaponVisible(bool visible)
    {
        weapon.SetActive(visible);
    }

}
