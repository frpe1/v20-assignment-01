using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 3f;

    [SerializeField] private LayerMask groundMask;

    [SerializeField] private Rigidbody playerBody;

    private bool grounded;

    bool shouldJump = false;
    private RaycastHit hitInfo;

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

     private void Update() {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        movement = new Vector3(x, playerBody.velocity.y, z);

        if (Input.GetKeyDown(KeyCode.Space)){
            shouldJump = true;
        }

        Debug.DrawRay(transform.position, -transform.up * 0.6f, Color.red);

        if (Physics.Raycast(transform.position, -transform.up, out hitInfo))
            grounded = true;
        else
            grounded = false;

    }

    // Update is called once per frame
    private void FixedUpdate() {
        Vector3 newPos = transform.position + (movement * speed * Time.fixedDeltaTime);
        
        playerBody.MovePosition(newPos);

        // grounded används för att förhindra att man kan hoppa flera gånger
        if (shouldJump && grounded) {
            shouldJump = false;
            grounded = false;
            playerBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
