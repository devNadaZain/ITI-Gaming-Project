using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    public float JumpStrength = 5.0f;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);


        if (Input.GetKeyDown(KeyCode.Space) )
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpStrength);
        }
    }


}


