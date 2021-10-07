using Abilities;
using Healths;
using UnityEngine;

public class UseItem : MonoBehaviour, ITrigger
{
    private PlayerHealth PlayerHealth => GetComponent<PlayerHealth>();
    private Inventory Inventory => GetComponent<Inventory>();
    
    public void Trigger()
    {
        if (Inventory.item == null) return;
        
        switch (Inventory.item.itemType)
        {
            case ItemType.Health:
            {
                PlayerHealth.GainHealth(Inventory.item.value);
            } break;
            case ItemType.Damage:
            {
                // Todo: Damage item functionality
            } break;
        }
        Inventory.DepleteItem();
    }
}
