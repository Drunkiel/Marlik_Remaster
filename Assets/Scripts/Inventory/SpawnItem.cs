using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;
    public bool keepObject;

    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnPickedItem()
    {
        Instantiate(item, player.position, Quaternion.identity);
        if(!keepObject) Destroy(gameObject);
    }
}
