using UnityEngine;

public class WallRunController : MonoBehaviour
{
    public Transform startPoint;
    public WallController _wallController;

    public void ResetMap()
    {
        _wallController.transform.localPosition = new Vector2(-30f, 6f);
        _wallController.player.position = startPoint.position;
    }
}
