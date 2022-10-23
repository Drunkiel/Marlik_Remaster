using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Transform pointToTeleport;

    TriggerController _triggerController;
    LoadingScreen _loadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        _triggerController = GetComponent<TriggerController>();
        _loadingScreen = GameObject.FindGameObjectWithTag("LoadingScreen").GetComponent<LoadingScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggerController.isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            Teleport();
        }
    }

    void Teleport()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        _loadingScreen.StartCoroutine("StartLoading", "£adowanie...");
        player.transform.position = pointToTeleport.position;
    }
}
