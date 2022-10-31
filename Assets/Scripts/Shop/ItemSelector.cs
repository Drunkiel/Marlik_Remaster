using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSelector : MonoBehaviour
{
    public int itemID;

    public GameObject item;
    public int price;

    [TextArea(4, 10)]
    public string valuesStats;

    public bool isBougth;

    public TMP_Text statsText;

    public BuyItemController _itemController;
    ItemFunction _itemFunction;

    void Start()
    {   
        _itemFunction = item.GetComponent<PickupItem>().itemBtn.GetComponent<ItemFunction>();
        valuesStats = "Dodatkowe HP: " + _itemFunction.additionalHP + 
                      "\r\nDodatkowy Atak: " + _itemFunction.additionalAttack +
                      "\r\nCena: " + price;
    }

    void Update()
    {
        if (isBougth) GetComponent<Button>().interactable = false;
    }

    public void SelectItem()
    {
        statsText.text = valuesStats;
        _itemController.price = price;
        _itemController.soldItem = item;
        _itemController.pickedItem = gameObject;
    }
}
