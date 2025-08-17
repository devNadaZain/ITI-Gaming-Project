using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    public float JumpStrength = 5.0f;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //move to right and left
        float moveY = Input.GetAxis("Horizontal");  
        transform.Translate(Vector3.right * moveY * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpStrength, ForceMode2D.Impulse);
            //Animation jump
            anim.SetTrigger("isJump");


        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            //Animation run
            anim.SetBool("isDead", true);
        }

    }

}
