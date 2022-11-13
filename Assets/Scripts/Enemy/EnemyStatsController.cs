using UnityEngine;

public class EnemyStatsController : MonoBehaviour
{
    public int health;
    public float walkSpeed;
    public int damage;

    DeathReward _deathReward;

    void Start()
    {
        _deathReward = GetComponent<DeathReward>();
    }

    public void TakeDamage(int value)
    {
        health -= value;

        if (health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        _deathReward.GiveReward();
        Destroy(gameObject);
    }
}
