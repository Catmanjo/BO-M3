using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float waitTime = 1;
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        
        rb.velocity = rb.velocity + (transform.right * speed * moveHorizontal);


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Runtime());
        }

    }
    IEnumerator Runtime()
    {
        speed = 50;
        yield return new WaitForSeconds(waitTime / 10);
        speed = 10;
    }
}