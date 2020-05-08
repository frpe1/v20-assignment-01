using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSmoothly : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float cameraSpeed = 15f;
    // public float zOffset = 22f;
    [SerializeField] private FloatVariable zOffsetScriptableObject;

    [SerializeField] private float zOffsetInit;     // Startvärdet för zOffset

    [SerializeField] private bool isFollow = true;


    void Start() {
        zOffsetScriptableObject.value = zOffsetInit;
    }


    // Update is called once per frame
    void Update()
    {
        // undvik köra detta om vi inte har någon referens
        if (target) {
            Vector3 newPos = transform.position;
            newPos.x = target.position.x;
            newPos.z = target.position.z - zOffsetScriptableObject.value;

            if (!isFollow) transform.position = newPos; 
            else transform.position = Vector3.Lerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
        }
    }
}
