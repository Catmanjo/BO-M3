using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    float jump = 5;
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "car")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("meow");
            jump = 2;
        }
    }

    public float jumpSpeed = 100.0f;

    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    float movementSpeed;
    // Update is called once per frame
    void Update()
    {
        float amountToMove = movementSpeed * Time.deltaTime;
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
        rb.AddForce(movement, ForceMode.Force);

        if (Input.GetKeyDown("space") && jump > 0)
        {
            rb.AddForce(Vector3.up * jumpSpeed * 2 * jump);
            jump--;


        }

    }
}