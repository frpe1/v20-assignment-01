using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/points")]
public class Points : ScriptableObject
{
    public int points;


    public void IncreasePoints(int v) {
        Debug.Log("Increase value");
        points = points + 1;
    }

}
