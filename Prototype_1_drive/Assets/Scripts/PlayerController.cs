using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 150;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
    // Moves the vehicle forward amd back based on VerticalInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
    // Moves the vehicle left and right based on horizontalInput
        transform.Rotate(Vector3.up,turnSpeed * horizontalInput * Time.deltaTime);
    }
}
