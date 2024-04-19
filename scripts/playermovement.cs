using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float horizontalInput;
    public float verticalInput;
    public Rigidbody playerRB;

    private float movementRangeX = 10f;

    private float movementRangeY = -4f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed);


        if (transform.position.x > movementRangeX)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }

         if (transform.position.x < -movementRangeX)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }

         if (transform.position.y < movementRangeY)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
