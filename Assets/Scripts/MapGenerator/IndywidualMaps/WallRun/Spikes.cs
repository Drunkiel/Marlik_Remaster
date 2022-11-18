using UnityEngine;

public class Spikes : MonoBehaviour
{
    public WallRunController _wallRunController;
    TriggerController _triggerController;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggerController.isTriggered) _wallRunController.ResetMap();
    }
}
