using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoints : MonoBehaviour
{
    public Points myScore;

    // Start is called before the first frame update
    /*
    void Start()
    {
        // Detta nollställer värdet från scratch
        myScore.points = 0;
    }
    */

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {

            if (myScore != null) {
                myScore.IncreasePoints(1);
                Destroy(gameObject);
            }
        }
    }
}
