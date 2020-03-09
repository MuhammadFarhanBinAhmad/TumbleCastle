using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Component[] rigid_Body_Part;

    public float move_Speed;

    private void Start()
    {
        //grab all rb inside gameobject
        rigid_Body_Part = GetComponents(typeof(Rigidbody));
        rigid_Body_Part = GetComponentsInChildren(typeof(Rigidbody));

        foreach (Rigidbody rb in rigid_Body_Part)
        {
            rb.isKinematic = true;
        }
    }

    private void FixedUpdate()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            foreach (Rigidbody rb in rigid_Body_Part)
            {
                rb.isKinematic = false;
            }
        }*/

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * vertical * move_Speed);
        transform.Rotate(0, horizontal * 5, 0);
    }

}
