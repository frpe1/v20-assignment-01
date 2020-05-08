using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Detta skapar en timer och håller reda på tiden i spelet.
// usage: applicera detta skript på ett tomt gameobject och lägg till objekten
// 
public class CountDownTimer : MonoBehaviour
{
    public int countdownTime;

    [SerializeField] private float timerSpeed = 2f;         // Anger hur snabb timern är. Ju större tal desto långsammare

    // Update is called once per frame
    private void Awake()
    {
        StartCoroutine(ActivateOnTimer());
    }

    IEnumerator ActivateOnTimer() {
        while(countdownTime > 0) {
            yield return new WaitForSeconds(timerSpeed); 

            countdownTime--;
        }
    }
}
