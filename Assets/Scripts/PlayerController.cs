using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    // PRIVATE variables

    private float speed = 20.0f;
    //[SerializeField] private float horsePower = 0;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    //private Rigidbody playerRb;
    //[SerializeField] GameObject centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        //for the more realistic driving to be used later

        //playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
        //moving the vehicle left & right / forwards & backwards
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


        // We´ll move the vehicle forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);

        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
