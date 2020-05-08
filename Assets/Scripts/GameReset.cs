using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReset : MonoBehaviour
{

    [SerializeField] private Points myScore;

    // Start is called before the first frame update
    void Start()
    {
        // Detta nollställer värdet från scratch
        myScore.points = 0;
    }
}
