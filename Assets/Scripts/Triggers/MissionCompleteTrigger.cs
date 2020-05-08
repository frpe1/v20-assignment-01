using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionCompleteTrigger : MonoBehaviour
{
    [SerializeField] private Text endMessage;

    private void OnTriggerEnter(Collider other) {
        endMessage.text = "MISSION COMPLETE!";
    }
}
