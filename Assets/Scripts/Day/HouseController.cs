using UnityEngine;

public class HouseController : MonoBehaviour
{
    public DayController _dayController;
    public LuckController _luckController;
    TriggerController _triggerController;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggerController.isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            _dayController.SkipDay();
            _luckController.DrawLuck();
        }   
    }
}
