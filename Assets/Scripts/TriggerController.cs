using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public bool isTriggered;
    public bool checkIfStay;

    public string tagToFind = "";

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(tagToFind))
        {
            isTriggered = true;
        }
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (checkIfStay && collider.CompareTag(tagToFind))
        {
            isTriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag(tagToFind))
        {
            isTriggered = false;
        }
    }
}
