using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Example : MonoBehaviour
{
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
