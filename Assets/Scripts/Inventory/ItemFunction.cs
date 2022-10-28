using UnityEngine;

public class ItemFunction : MonoBehaviour
{
    public int additionalHP;
    public int additionalAttack;

    public void UseItem()
    {
        PlayerStatsController playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatsController>();
        playerStats.health += additionalHP;
        playerStats.damage += additionalAttack;
    }
}
