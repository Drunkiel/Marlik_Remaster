using UnityEngine;
using TMPro;

public class BuyItemController : MonoBehaviour
{
    public int price;

    public GameObject soldItem;

    public TMP_Text textToShow;
    public GameObject pickedItem;

    PlayerStatsController _playerStatsController;
    SpawnItem _spawnItem;

    // Start is called before the first frame update
    void Start()
    {
        _playerStatsController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatsController>();
        _spawnItem = GetComponent<SpawnItem>();
    }

    public void BuyItem()
    {
        if(soldItem == null)
        {
            textToShow.text = "Wybierz item do kupna";
            return;
        }

        if (price > _playerStatsController.money) textToShow.text = "Masz zbyt ma³o pieniêdzy";
        else
        {
            _playerStatsController.money -= price;
            _spawnItem.item = soldItem;
            _spawnItem.SpawnPickedItem();
            pickedItem.GetComponent<ItemSelector>().isBougth = true;
        }
    }
}
