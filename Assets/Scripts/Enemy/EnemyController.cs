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
        CheckLuck();
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

    void CheckLuck()
    {
        switch (LuckController.instance.todaysLuck)
        {
            case 0:
                _statsController.damage += Mathf.RoundToInt(_statsController.damage * 0.2f);
                _statsController.health += Mathf.RoundToInt(_statsController.health * 0.2f);
                break;

            case 1:
                _statsController.damage += Mathf.RoundToInt(_statsController.damage * 0.1f);
                _statsController.health += Mathf.RoundToInt(_statsController.health * 0.1f);
                break;

            case 2:
                _statsController.damage += Mathf.RoundToInt(_statsController.damage * 0);
                _statsController.health += Mathf.RoundToInt(_statsController.health * 0);
                break;

            case 3:
                _statsController.damage -= Mathf.RoundToInt(_statsController.damage * 0.1f);
                _statsController.health -= Mathf.RoundToInt(_statsController.health * 0.1f);
                break;

            case 4:
                _statsController.damage -= Mathf.RoundToInt(_statsController.damage * 0.2f);
                _statsController.health -= Mathf.RoundToInt(_statsController.health * 0.2f);
                break;
        }
    }
}
