using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject resetLocation;
    [SerializeField] private float deathLevelPosition = -5f;


    private void Update() {
        // Läser av om spelaren befinner sig under deathLevelPosition isåfall
        // så återställer man spelarens position från start igen.

        if (player && resetLocation) {            
            if (player.transform.position.y < deathLevelPosition) {
                Debug.Log("lll");
                player.transform.position = new Vector3 (
                    resetLocation.transform.position.x, 
                    resetLocation.transform.position.y + 3f, 
                    resetLocation.transform.position.z);
            }
        }
    }
}
