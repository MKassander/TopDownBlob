using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Item", order = 4)]
public class SoItem : ScriptableObject
{
    public Sprite icon;
    public Color iconColor;
    public int value;
    public ItemType itemType;
}
public enum ItemType
{
    Health,
    Damage
}