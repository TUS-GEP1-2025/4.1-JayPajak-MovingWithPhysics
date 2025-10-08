using JetBrains.Annotations;
using UnityEngine;

public class movingPhysics : MonoBehaviour

{
    public Rigidbody2D theRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        Rigidbody2D Steve = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            theRB.linearVelocity = Vector2.right * 5;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            theRB.linearVelocity = Vector2.left * 5;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            theRB.AddForce(Vector2.up * 20);
        }


    }
}
