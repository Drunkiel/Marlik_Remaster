using TMPro;
using UnityEngine;
using UnityEngine.UI;

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
    public Slider healthSlider;
    public TMP_Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        UpdateBar();
    }

    public void TakeDamage(int dealDamage)
    {
        health -= dealDamage;

        if (health <= 0) Death();
        else UpdateBar();
    }

    void UpdateBar()
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
        healthText.text = health + " / " + maxHealth;
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

        UpdateBar();
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
