using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float constantRate;
    public bool hasStarted;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        constantRate = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted) {
            if(Input.anyKeyDown) {
                hasStarted = true;
            }
        } else {
            transform.position -= new Vector3(0f, constantRate * Time.deltaTime, 0f);
        }
    }
}
