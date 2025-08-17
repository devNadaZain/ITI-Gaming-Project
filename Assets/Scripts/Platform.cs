using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 2f;          
    public float distance = 3f;       

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (Vector3.Distance(startPos, transform.position) >= distance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (Vector3.Distance(startPos, transform.position) <= 0.05f)
            {
                movingRight = true;
            }
        }
    }


}
