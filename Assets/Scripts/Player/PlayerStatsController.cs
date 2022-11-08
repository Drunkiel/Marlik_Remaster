using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    [Header("Health")]
    public int health;
    public int maxHealth;

    [Header("Attack")]
    public int damage;
    public float attackSpeed;
    public float attackRange;

    [Header("Other")]
    public int level;
    public int money;

    public LoadingScreen _loadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Death();
        }
    }

    public void TakeDamage(int dealDamage)
    {
        health -= dealDamage;

        if (health <= 0)
        {
            Death();
        }
    }

    public void Heal(int amountOfHP)
    {
        if((health + amountOfHP) > maxHealth)
        {
            health += (health + amountOfHP) - maxHealth;
        }
        else
        {
            health += amountOfHP;
        }
    }

    public void Rest()
    {
        Heal(maxHealth);
    }

    void Death()
    {
        _loadingScreen.StartCoroutine("StartLoading", "Zgin¹³eœ/aœ");
        transform.position = new Vector3(-2.8f, -3, 0);
        Rest();
    }
}
