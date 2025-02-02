using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 10.0f;
    private float zBound = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerPosition();
    }

    //Moves the player based on player input
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //Keeps the player constrained to specific z values
    void ConstrainPlayerPosition()
    {
        if(transform.position.z < -zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if(transform.position.z > zBound){
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
