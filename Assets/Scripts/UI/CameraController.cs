using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public bool followX;
    public bool followY;

    public float delay;
    public float extraHeight;
    private Vector3 currVelocity;

    // Update is called once per frame
    void Update()
    {
        NewCameraPosition(followX, followY);
    }

    void NewCameraPosition(bool x, bool y)
    {
        float xPos = 0;
        float yPos = 0;

        if (x) xPos = Player.transform.position.x;
        if(y) yPos = Player.transform.position.y + extraHeight;

        Vector3 newCameraPosition = new Vector3(xPos, yPos, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, newCameraPosition, ref currVelocity, delay);
    }
}
