using JetBrains.Annotations;
using UnityEngine;

public class movingPhysics : MonoBehaviour

{
    public Rigidbody2D theRB;

    public float MovementSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        //Rigidbody2D Steve = gameObject.GetComponent<Rigidbody2D>();
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

        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            theRB.linearVelocity = Vector2.left * MovementSpeed;
        }
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            theRB.AddForce(Vector2.up * 20);
        }
    }
}
