﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr : MonoBehaviour
{
    public GameObject prt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {
           GameObject part= Instantiate(prt, contact.point, Quaternion.identity);
            Destroy(part,1);
        }
       
    }
}