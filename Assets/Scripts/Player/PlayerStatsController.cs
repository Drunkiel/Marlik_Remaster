using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public int damage;

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
            _loadingScreen.StartCoroutine("StartLoading", "Zgin¹³eœ/aœ");
            Death();
        }
    }

    void Death()
    {
        _loadingScreen.StartCoroutine("StartLoading", "Zgin¹³eœ/aœ");
        transform.position = new Vector3(0, 0, 0);
        health = maxHealth;
    }

    public void Rest()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Death();
        }
    }
}
