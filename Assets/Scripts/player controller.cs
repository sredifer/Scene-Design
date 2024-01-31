using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Properties of RigidBody: AddForce, velocity
    Rigidbody rb;

    [SerializeField]
    float speed = 10;

    bool onGround = false;

    [SerializeField]
    float jumpHeight = 8;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMove(InputValue value) // Control type: Vector 2 --> (x, y)
    {
        Vector2 input = value.Get<Vector2>();

        Debug.Log(input);

        // transform.position, transform.rotation
        // transform.forward (Vector3, points in front of player, want to scale with input), transform.right

        rb.velocity = input.y * transform.forward + input.x * transform.right;
        rb.velocity *= speed;
    }

    void OnJump()
    {
        if (onGround)
        {
            rb.velocity = transform.up * jumpHeight;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // our feet are touching the ground
            onGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // our feet are touching the ground
            onGround = false;
        }
    }
}

