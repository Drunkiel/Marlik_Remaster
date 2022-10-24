using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public bool canBeInteracted = true;
    public bool oppositeValue;

    InteractionController _interactionController;
    TriggerController _triggerController;

    // Start is called before the first frame update
    void Start()
    {
        _interactionController = GameObject.FindGameObjectWithTag("InteractionController").GetComponent<InteractionController>();
        _triggerController = GetComponent<TriggerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canBeInteracted && (_triggerController.isTriggered == oppositeValue))
        {
            ChangeValue();
        }
    }

    void ChangeValue()
    {
        oppositeValue = !_triggerController.isTriggered;

        if (!oppositeValue) _interactionController.Show();
        if (oppositeValue) _interactionController.Hide();
    }
}
