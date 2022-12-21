using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManage : MonoBehaviour
{
    public Vector3 offset;// внутри offset тоэе есть x,y,z
    public GameObject target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x + offset.x , target.transform.position.y + offset.y, target.transform.position.z + offset.z);
    }
}
