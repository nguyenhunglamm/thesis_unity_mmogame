﻿using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float rotateSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), rotateSpeed);
    }
}
