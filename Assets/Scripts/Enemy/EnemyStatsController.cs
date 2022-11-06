using UnityEngine;

public class EnemyStatsController : MonoBehaviour
{
    public int health;
    public float walkSpeed;
    public int damage;

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
        Destroy(gameObject);
    }
}
