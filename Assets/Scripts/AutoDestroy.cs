using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, time);   
    }
}
