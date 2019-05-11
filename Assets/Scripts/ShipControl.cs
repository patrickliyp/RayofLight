using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        //Vector3 tempVect = new Vector3(h, 0, v);
        //tempVect = tempVect.normalized * speed * Time.deltaTime;
        //rb.MovePosition(transform.position + tempVect);

        if (Input.GetKey("w"))
        {
            Vector3 tempVect = new Vector3(0, 0, 1);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(transform.position + tempVect);
        }

        if (Input.GetKey("a"))
        {
            rb.transform.Rotate(0, 0, -30);
        }

    }
}
