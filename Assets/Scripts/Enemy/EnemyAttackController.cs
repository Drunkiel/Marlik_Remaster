using UnityEngine;

public class EnemyAttackController : MonoBehaviour
{
    public float cooldown;
    public float resCooldown;
    public int attackRange;
    public bool readyToAttack;
    public LayerMask mask;

    public Transform attackPoint;

    EnemyStatsController _statsController;

    void Start()
    {
        _statsController = GetComponent<EnemyStatsController>();
    }

    void Update()
    {
        if(cooldown > 0) cooldown -= Time.deltaTime;
    }

    public void Attack()
    {
        if (readyToAttack && cooldown <= 0)
        {
            //Detecting player
            Collider2D[] collision = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, mask);

            //Do damage to player
            foreach (Collider2D hited in collision)
            {
                hited.TryGetComponent<PlayerStatsController>(out PlayerStatsController playerStats);
                playerStats.TakeDamage(_statsController.damage);
            }

            cooldown = resCooldown;
            readyToAttack = false;
        }
    }
}
