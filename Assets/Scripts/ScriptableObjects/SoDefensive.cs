using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Shield", order = 2)]
public class SoDefensive : ScriptableObject
{
    public GameObject prefab;
    public int delay, duration;
}
