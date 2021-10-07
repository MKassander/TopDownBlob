using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject iconGo;
    private Image _icon;
    [HideInInspector] public SoItem item;

    private void Start()
    {
        
    }

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
