using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVehicle : MonoBehaviour
{
    float speed = 10.0f;
    float forwardInput;
    float turnSpeed = 30.0f;
    float turnInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*speed*Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * turnInput);
        
    }
}
