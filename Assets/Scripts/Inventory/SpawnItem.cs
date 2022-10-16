using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;

    public void SpawnPickedItem()
    {
        Instantiate(item, Vector2.zero, Quaternion.identity);
        Destroy(gameObject);
    }
}
