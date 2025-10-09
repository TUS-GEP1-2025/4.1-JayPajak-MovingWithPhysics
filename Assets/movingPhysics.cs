using JetBrains.Annotations;
using UnityEngine;

public class movingPhysics : MonoBehaviour

{
    public Rigidbody2D theRB;

    public float MovementSpeed = 5.0f;
    public float JumpForce = 200.0f;

    public bool isGrounded = false;

    public AudioSource theAudioSource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Rigidbody2D Steve = gameObject.GetComponent<Rigidbody2D>();
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftAndRight();
        Jump();
    }

    public void MoveLeftAndRight()
    {
        if (Input.GetKey(KeyCode.RightArrow) == true )
        {
            theRB.linearVelocity = Vector2.right * MovementSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            theRB.linearVelocity = Vector2.left * MovementSpeed;
        }

    }

    public void Jump()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            theRB.AddForce(Vector2.up * 200);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GroundPlatform")
        {
            isGrounded = true;
        }

        if (collision.gameObject.tag == "Wall")
        {
            theAudioSource.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GroundPlatform")
        {
            isGrounded = false;
        }
    }


}
