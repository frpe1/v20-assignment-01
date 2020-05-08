using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoneTrigger : MonoBehaviour
{
    [SerializeField] FloatVariable zOffsetScriptObject;
    [SerializeField] float zOffsetValue; // zOffsetvalue för denna zon för kameran. 


    private void OnTriggerEnter(Collider other) {
        Debug.Log("trigger camera zone");
        if (other.gameObject.tag == "Player") {
            Debug.Log("is it the player ?");
            if (zOffsetScriptObject)
                zOffsetScriptObject.value = zOffsetValue;
        }
    }
}
