using UnityEngine;

public class StatueController : MonoBehaviour
{
    public Sprite statueOnSprite;

    TriggerController _triggerController;
    InteractionObject _interactionObject;
    PlayerStatsController _playerStatsController;
    RandomTextController _randomText;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
        _interactionObject = GetComponent<InteractionObject>();
        _randomText = GetComponent<RandomTextController>();
        _playerStatsController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatsController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_interactionObject.canBeInteracted && _triggerController.isTriggered && Input.GetKeyDown(KeyCode.E)) ChangeState();
    }

    void ChangeState()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = statueOnSprite;

        _playerStatsController.Heal(Mathf.RoundToInt(_playerStatsController.maxHealth * 0.1f));
        _randomText.SpawnText();

        _interactionObject.canBeInteracted = false;
    }
}
