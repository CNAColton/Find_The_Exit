using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 destination = new Vector3(horizontal, 0, vertical);     
        GetComponent<Rigidbody>().velocity = destination * speed;
        
    }
}
