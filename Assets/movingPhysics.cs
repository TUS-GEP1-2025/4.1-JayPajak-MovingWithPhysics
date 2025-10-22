using JetBrains.Annotations;
using UnityEngine;

public class movingPhysics : MonoBehaviour

{
    public Rigidbody2D theRB;

    public float MovementSpeed = 5.0f;
    public float JumpForce = 200.0f;

    public bool isGrounded = false;

    public AudioSource theAudioSource;

    public Animator theAnimator;


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
        if (Input.GetKey(KeyCode.RightArrow) == true && isGrounded)
        {
            theRB.linearVelocity = Vector2.right * MovementSpeed;
            theAnimator.SetFloat("walkSpeed", MovementSpeed);
            Vector3 theScale = transform.localScale;
            theScale.x = 1;
            transform.localScale = theScale;
        }

        else if (Input.GetKey(KeyCode.LeftArrow) == true && isGrounded)
        {
            theRB.linearVelocity = Vector2.left * MovementSpeed;
            theAnimator.SetFloat("walkSpeed", MovementSpeed);
            Vector3 theScale = transform.localScale;
            theScale.x = -1;
            transform.localScale = theScale;

        }

        else if (isGrounded)
        {
            theRB.linearVelocity = new Vector2(0, theRB.linearVelocity.y);
            theAnimator.SetFloat("walkSpeed", 0);

        }

    }

    public void Jump()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) == true)
        {
            theRB.AddForce(Vector2.up * JumpForce);
            isGrounded = false;
            theAnimator.SetBool("Jump", true);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "GroundPlatform")
        {
            isGrounded = true;
            theAnimator.SetBool("Jump", false);

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
