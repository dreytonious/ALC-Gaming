﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Move Speed of GameObject
    public float speed = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves gameobject
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
