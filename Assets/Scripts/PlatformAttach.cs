using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("on trigger enter");
        if (other.gameObject == Player) {
           
            Player.transform.parent = transform; // koppla spelaren till plattformen så man inte ramla av
            
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == Player) {
            Player.transform.parent = null; // när vi hoppar ifrån så nollställer vi plattformen.
        }
    }
}
