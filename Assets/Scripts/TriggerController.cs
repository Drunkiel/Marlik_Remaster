using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool isTriggered;
    public string tag = "";

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(tag))
        {
            isTriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag(tag))
        {
            isTriggered = false;
        }
    }
}
