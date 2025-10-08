using JetBrains.Annotations;
using UnityEngine;

public class movingPhysics : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        PublicAPIAttribute Rigidbody2D theRB;
        Rigidbody2D Steve = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vectorRight;
        vectorRight = Vector2.right * 5;
    }
}
