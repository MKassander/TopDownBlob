using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Projectile", order = 1)]
public class SO_Projectile : ScriptableObject
{
    public GameObject prefab;
    public Sprite icon;
    public int delay, damage;
}
