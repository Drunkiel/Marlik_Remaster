using UnityEngine;

public class WallRunController : MonoBehaviour
{
    public Transform startPoint;
    public WallController _wallController;
    LoadingScreen _loadingScreen;

    void Start()
    {
        _loadingScreen = GameObject.FindGameObjectWithTag("LoadingScreen").GetComponent<LoadingScreen>();
    }

    public void ResetMap()
    {
        _loadingScreen.StartCoroutine("StartLoading", "Szybciej tymi nó¿kami ruszaj...");
        _wallController.transform.localPosition = new Vector2(-34f, 3.87f);
        _wallController.player.position = startPoint.position;
    }
}
