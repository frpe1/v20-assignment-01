﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("hit");
    }
}
