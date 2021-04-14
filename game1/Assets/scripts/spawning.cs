using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public Transform startPos;
    public int nextstep = 0;
    public GameObject path;


    void Start()
    {
        
    }
    void Update()
    {
        nextstep += 15;
        Instantiate(path, new Vector3(startPos.position.x,startPos.position.y, transform.position.z + nextstep), Quaternion.identity);       
    }
}
