﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public static float rotatorSpeed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, rotatorSpeed * Time.deltaTime);
    }
}
