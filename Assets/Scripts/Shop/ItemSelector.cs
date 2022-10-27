using TMPro;
using UnityEngine;

public class ItemSelector : MonoBehaviour
{
    public GameObject item;
    public int price;
    public string valuesStats;

    public TMP_Text statsText;

    public BuyItemController _itemController;

    public void SelectItem()
    {
        statsText.text = valuesStats;
        _itemController.price = price;
        _itemController.soldItem = item;
    }
}
