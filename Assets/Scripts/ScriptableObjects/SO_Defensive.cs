using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Shield", order = 2)]
public class SO_Defensive : ScriptableObject
{
    public GameObject prefab;
    public Sprite icon;
    public int delay, duration;
}
