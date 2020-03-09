using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject Player;

    public GameObject spawn_Point;

    int force = 10000;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {            
            //Player.GetComponent<Rigidbody>().AddRelativeForce(spawn_Point.transform.up * force);
        }
    }
}
