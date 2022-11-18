using UnityEngine;

public class WallController : MonoBehaviour
{
    public float speed;
    private float startSpeed;
    public int distance;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveWall();   
    }

    void MoveWall()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        CheckPlayer();
    }

    void CheckPlayer()
    {
        Vector2 diffrence = new Vector2(player.position.x - gameObject.transform.position.x, transform.position.y);

        if (diffrence.x >= distance) speed = speed + diffrence.x / 10;
        else speed = startSpeed;
    }
}
