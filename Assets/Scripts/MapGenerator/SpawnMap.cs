using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public bool isMapGenerated;
    public Transform place;

    public GeneratorController _generatorController;
    TriggerController _triggerController;

    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
    }

    void Update()
    {
        if(_triggerController.isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            Generate();
        }
    }

    void CheckIfMapExists()
    {
        if (isMapGenerated)
        {
            _generatorController.DestroyMap();
            isMapGenerated = false;
        }
    }

    void Generate()
    {
        CheckIfMapExists();

        _generatorController.GenerateMap(place);
        isMapGenerated = true;
    }
}
