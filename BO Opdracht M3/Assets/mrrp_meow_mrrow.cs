using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mrrpmeowmrrow : MonoBehaviour
{

    public Transform _camera;
    public float speed, rotSpeed;
    private float rotX, rotY;
    private Rigidbody rb;
    private Vector3 offset;
    private Vector3 moveDelta;






    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }




    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    void Rotate()
    {
        rotY += Input.GetAxisRaw("Mouse X") * rotSpeed * Time.deltaTime;
        rotX -= Input.GetAxisRaw("Mouse Y") * rotSpeed * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -90f, 50f);

        transform.rotation = Quaternion.Euler(0f, rotY, 0f);
    }
}
