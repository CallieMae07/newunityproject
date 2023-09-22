using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxSpeed = 5.0f;
    bool isOnGround = false;

    
//create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
       //find the rigidbody component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //create a 'float' that will be equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizontal");

        //change the X velocity of the rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX*speed, playerObject.velocity.y );

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);
    }
}
