using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}