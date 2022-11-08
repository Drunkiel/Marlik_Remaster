using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    public bool readyToAttack;
    public bool attacking;
    private float cooldown;

    [Header("Attack requirements")]
    public Transform attackPoint;
    public LayerMask mask;

    PlayerController _playerController;
    PlayerStatsController _statsController;
    public PlayerAnimationController _animationController;

    // Start is called before the first frame update
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
        _statsController = GetComponent<PlayerStatsController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetReady();
    }

    void Attack()
    {
        if (_playerController.onTheGround && Input.GetKeyDown(KeyCode.Mouse0) && readyToAttack)
        {
            attacking = true;
            _animationController.AttackAnimation();

            //Detecting player
            Collider2D[] collision = Physics2D.OverlapCircleAll(attackPoint.position, _statsController.attackRange, mask);

            //Do damage to player
            foreach (Collider2D hited in collision)
            {
                hited.TryGetComponent<EnemyStatsController>(out EnemyStatsController enemyStats);
                enemyStats.TakeDamage(_statsController.damage);
            }
        }
    }

    void GetReady()
    {
        if (!readyToAttack)
        {
            attacking = false;

            if(cooldown <= 0)
            {
                readyToAttack = true;
                cooldown = _statsController.attackSpeed;
            }
            else
            {
                cooldown -= Time.deltaTime;
            }
        }
        else
        {
            Attack();
        }
    }

    //For animation
    public void StopAttack()
    {
        readyToAttack = false;
    }
}
