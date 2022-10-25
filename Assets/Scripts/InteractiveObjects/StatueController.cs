using UnityEngine;

public class StatueController : MonoBehaviour
{
    public Sprite statueOnSprite;

    TriggerController _triggerController;
    InteractionObject _interactionObject;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
        _interactionObject = GetComponent<InteractionObject>();
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

        _interactionObject.canBeInteracted = false;
    }
}
