using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;

    float x_Axis,y_Axis;
    public float mouse_Speed;
    
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//lock mouse to center and hide mouse cursor
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        {
            float horizontal = Input.GetAxis("Mouse X") ;
            float vertical = Input.GetAxis("Mouse Y") ;
            float mouse_Scroll = Input.GetAxis("Mouse ScrollWheel");

            x_Axis = horizontal * mouse_Speed;
            y_Axis = vertical * mouse_Speed;

            transform.RotateAround(target.transform.position, Vector3.up, x_Axis);
            transform.RotateAround(target.transform.position, Vector3.right, y_Axis);

            transform.LookAt(target);
        }

    }
}
