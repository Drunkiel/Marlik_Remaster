using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public int i;
    private InventoryController _inventoryController;
    
    void Start()
    {
        _inventoryController = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryController>();
    }

    void Update()
    {
        if (transform.childCount <= 0)
        {
            _inventoryController.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<SpawnItem>().SpawnPickedItem();
            Destroy(child.gameObject);
        }
    }
}
