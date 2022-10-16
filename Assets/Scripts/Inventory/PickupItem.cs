using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public GameObject itemBtn;

    InventoryController _inventoryController;
    TriggerController _triggerController;

    void Start()
    {
        _inventoryController = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryController>();
        _triggerController = GetComponent<TriggerController>();
    }

    void Update()
    {
        if (_triggerController.isTriggered && Input.GetKeyUp(KeyCode.E)) Pickup();
    }

    void Pickup()
    {
        for (int i = 0; i < _inventoryController.slots.Length; i++)
        {
            if (_inventoryController.isFull[i] == false)
            {
                _inventoryController.isFull[i] = true;
                Instantiate(itemBtn, _inventoryController.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }
    }
}
