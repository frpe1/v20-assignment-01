using UnityEngine;

// Denna klass teleporterar spelaren från en plats till en annan i samma scen
// usage: sätt ett empty object för target för vart man ska teleporteras till
// drag and drop detta skript till det objekt som ska fungera som en teleporteringsapparat. 
// viktiga är att det objekt man drar detta skript till har en collision komponent som är satt som en trigger. 
public class PortalTrigger : MonoBehaviour
{
    [SerializeField] private GameObject targetLocation;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            if (targetLocation)
                other.gameObject.transform.position = targetLocation.transform.position;
        }
    }
}