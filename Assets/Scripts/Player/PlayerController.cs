using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    public float sprintSpeed;
    public float jumpForce;

    public bool onTheGround;
    public Transform groundTester;
    public LayerMask layerMask;

    Rigidbody2D rgBody;
    private bool dirToRight;

    public PlayerAnimationController _animationController;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onTheGround = Physics2D.OverlapCircle(groundTester.position, 0.7f, layerMask);

        Movement();
    }

    void Movement()
    {
        float x = Input.GetAxis("Horizontal");

        Idle(x);
        Walk(x);
        Sprint(x);
        Jump();

        if(x < 0 && !dirToRight)
        {
            Flip();
        }

        if (x > 0 && dirToRight)
        {
            Flip();
        }
    }

    void Idle(float x)
    {
        if(x == 0 && onTheGround)
        {
            _animationController.IdleAnimation();
        }
    }

    void Walk(float x)
    {
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            if((x > 0 || x < 0) && onTheGround) _animationController.RunAnimation();

            rgBody.velocity = new Vector2(walkSpeed * x, rgBody.velocity.y);
        }
    }

    void Sprint(float x)
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if ((x > 0 || x < 0) && onTheGround) _animationController.RunAnimation();

            rgBody.velocity = new Vector2(sprintSpeed * x, rgBody.velocity.y);
        }
    }

    void Jump()
    {
        if (!onTheGround) _animationController.JumpAnimation();

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && onTheGround)
        {
            rgBody.AddForce(new Vector2(0f, jumpForce));
        }
    }

    void Flip()
    {
        dirToRight = !dirToRight;
        Vector3 playerScale = gameObject.transform.localScale;
        playerScale.x *= -1;
        gameObject.transform.localScale = playerScale;
    }
}
