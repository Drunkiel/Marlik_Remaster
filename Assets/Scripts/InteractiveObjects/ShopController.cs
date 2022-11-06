using UnityEngine;

public class ShopController : MonoBehaviour
{
    public OpenCloseUI _openCloseUI;
    TriggerController _triggerController;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggerController.isTriggered && Input.GetKeyDown(KeyCode.E)) _openCloseUI.OpenClose();
        if (_openCloseUI.isOpen && !_triggerController.isTriggered) _openCloseUI.OpenClose();
    }
}
