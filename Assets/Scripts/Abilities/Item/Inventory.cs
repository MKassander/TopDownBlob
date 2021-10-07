using UnityEngine;
using UnityEngine.UI;

namespace Abilities.Item
{
    public class Inventory : MonoBehaviour
    {
        public GameObject iconGo;
        private Image _icon;
        [HideInInspector] public SoItem item;

        public void AddItem(SoItem soItem)
        {
            _icon = iconGo.GetComponent<Image>();
            item = soItem;
            iconGo.SetActive(true);
            _icon.sprite = item.icon;
            _icon.color = item.iconColor;
        }

        public void DepleteItem()
        {
            item = null;
            iconGo.SetActive(false);
        }
    }
}
