using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 28.0f;
    public GameObject ProjectileFood;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Collects input data on horizonta controls
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player to the left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Places a boundary on the left
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Places a boundary to the right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(ProjectileFood,transform.position,ProjectileFood.transform.rotation);
        }
    }
}
