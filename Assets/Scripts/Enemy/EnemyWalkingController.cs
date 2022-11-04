using UnityEngine;

public class EnemyWalkingController : MonoBehaviour
{
    public float walkTime;

    public float distanceToTrigger;
    public bool isPlayerNearby;

    private bool dirToRight;
    Rigidbody2D rgBody;

    EnemyStatsController _statsController;
    EnemyAttackController _attackController;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
        _statsController = GetComponent<EnemyStatsController>();
        _attackController = GetComponent<EnemyAttackController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlayerNearby) RandomWalk();
        else GetPlayerPosition();
    }

    void RandomWalk()
    {
        if(walkTime <= 0)
        {
            int value = Random.Range(0, 4);

            if (value > 0)
            {
                Flip();
                _statsController.walkSpeed = 1; 
            }
            else _statsController.walkSpeed = 0;

            walkTime = Random.Range(1, 8);
        }
        else
        {
            if (dirToRight) rgBody.velocity = new Vector2(_statsController.walkSpeed, rgBody.velocity.y);
            else rgBody.velocity = new Vector2(-_statsController.walkSpeed, rgBody.velocity.y);

            walkTime -= Time.deltaTime;
        }
    }

    void GetPlayerPosition()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player.position.x <= distanceToTrigger) _attackController.readyToAttack = true;

        FollowPlayer(player);
    }

    void FollowPlayer(Transform player)
    {
        Vector2 diffrence = new Vector2(player.position.x - gameObject.transform.position.x, transform.position.y);
        rgBody.velocity = diffrence * (_statsController.walkSpeed / 2);
    }

    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 enemyScale = gameObject.transform.localScale;
        enemyScale.x *= -1;
        gameObject.transform.localScale = enemyScale;
    }
}
