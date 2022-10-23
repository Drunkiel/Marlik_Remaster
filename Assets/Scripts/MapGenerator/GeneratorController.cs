using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public GameObject[] allMaps;

    public void GenerateMap(Transform placeToSpawn)
    {
        Instantiate(allMaps[0], placeToSpawn.position, Quaternion.identity, placeToSpawn);
    }

    public void DestroyMap()
    {
        GameObject map = GameObject.FindGameObjectWithTag("GeneratedMap");
        Destroy(map);
    }
}
