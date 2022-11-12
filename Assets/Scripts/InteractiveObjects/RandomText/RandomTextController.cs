using UnityEngine;

public class RandomTextController : MonoBehaviour
{
    public GameObject prefab;

    public void SpawnText()
    {
        Instantiate(prefab, new Vector3(-8, 0, 10), Quaternion.Euler(0, -25, 0), transform);
    }
}
