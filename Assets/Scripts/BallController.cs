/*
 
         hVal = Input.GetAxis("Horizontal");
        Debug.Log("This is horizontal: " + hVal);
         vVal=  Input.GetAxis("Vertical");
        Debug.Log("this is vertical comp" + vVal);

        Debug.Log(myMailBox);
        Debug.Log(gameStarted);
        Debug.Log(myBox);
        print(myFloorPacket);

    string myMailBox = "Jatin`s Letter";
    int myBox = 2000;
    float myHeightRadar = 5.4f;
    float myFloorPacket = 30.668f;
    char myFavAlphabet = 'K';
    bool gameStarted = false;

        // Move the object based on user input
        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentPosition += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentPosition += Vector3.down * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentPosition += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentPosition += Vector3.left * moveSpeed * Time.deltaTime;
        }

        // Update the object's position
        transform.position = currentPosition;

Vector3 currentPosition = transform.position;


 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class BallController : MonoBehaviour
{
    // variables <TYPE > <VARIABLE NAME>
    

    // Input 
    private float hVal;

    //Variables
    private float vVal;
    public float moveSpeed = 10f;
    public Rigidbody rb;

    private void Awake()
    {
        // Get the Rigidbody component attached to this GameObject
        print("This is my awake function");
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
   /* void Start()
    {

        print("this is my start function");


    }
   */

    // Update is called once per frame
    void Update()
    {

        // good for handling inputs and animations 
        print("this is my update function");
        // Get the current position of the object
         
        ProcessInputs();

    }

    private void FixedUpdate()
    {
        //print("This is Fixed Update");
        //Movements
        Move();
    }

    private void ProcessInputs()
    {
        hVal = Input.GetAxis("Horizontal");
        vVal = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(hVal, 0f, vVal) * moveSpeed);
    }

}

