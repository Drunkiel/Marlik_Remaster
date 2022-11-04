using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemyStatsController _statsController;
    EnemyAttackController _attackController;
    EnemyWalkingController _walkingController;
    TriggerController _triggerController;

    // Start is called before the first frame update
    void Start()
    {
        _statsController = GetComponent<EnemyStatsController>();
        _attackController = GetComponent<EnemyAttackController>();
        _walkingController = GetComponent<EnemyWalkingController>();  
        _triggerController = GetComponent<TriggerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    void Controller()
    {
        //Checking if player is in trigger radius
        if (_triggerController.isTriggered) _walkingController.isPlayerNearby = true;
        else _walkingController.isPlayerNearby = false;

        //Atacking
        if (_attackController.readyToAttack) _attackController.Attack();
    }
}
