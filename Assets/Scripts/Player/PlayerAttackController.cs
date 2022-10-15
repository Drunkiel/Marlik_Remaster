using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    public float cooldown;
    public bool readyToAttack;
    public bool attacking;

    PlayerController _playerController;
    public PlayerAnimationController _animationController;

    // Start is called before the first frame update
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetReady();
    }

    void Attack()
    {
        if (_playerController.onTheGround && Input.GetKeyDown(KeyCode.Mouse0))
        {
            attacking = true;
            _animationController.AttackAnimation();
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
                cooldown = 0.5f;
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

    public void StopAttack()
    {
        readyToAttack = false;
    }
}
