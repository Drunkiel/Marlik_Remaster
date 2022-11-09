using UnityEngine;

public class DeathReward : MonoBehaviour
{
    public int money;
    public GameObject[] items;

    PlayerStatsController _playerStatsController;

    // Start is called before the first frame update
    void Start()
    {
        _playerStatsController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatsController>();
    }

    public void GiveReward()
    {
        _playerStatsController.money += money;

        int randomNumber = Random.Range(0, 4);

        if(randomNumber > 0)
        {
            int randomItem = Random.Range(0, items.Length);
            Instantiate(items[randomItem], transform.position, Quaternion.identity);
        }
    }
}
