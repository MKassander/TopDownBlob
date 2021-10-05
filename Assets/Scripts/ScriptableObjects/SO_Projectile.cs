using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Projectile", order = 1)]
public class SoProjectile : ScriptableObject
{
    public GameObject prefab;
    public Sprite icon;
    public int delay, damage;
}
