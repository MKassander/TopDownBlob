using Abilities.Item;
using UnityEngine;

namespace Items
{
    public class ItemPickUp : MonoBehaviour
    {
        [SerializeField] private SoItem item;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                other.GetComponent<Inventory>().AddItem(item);
                Destroy(gameObject);
            }
        }
    }
}
