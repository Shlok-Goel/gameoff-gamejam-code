using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, 0f);
        }
        else if(Input.GetKey(KeyCode.A))
                {
            rb.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f,speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f,-speed);
        }
        else if (Input.GetKey(KeyCode.None)) {
            rb.velocity = new Vector2(0f, 0f);
            rb.drag = 30f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.name);
    }
}
