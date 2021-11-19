using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    float X, Z;
    public Joystick controller;
    public float speed;
    public float rotspeed;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        X = controller.Horizontal;
        Z = controller.Vertical;

        Vector3 Movement = new Vector3(X,0f,Z);
        Movement.Normalize();
        transform.Translate(Movement * speed * Time.deltaTime, Space.World);

        if (Movement != Vector3.zero)
        {
            transform.forward = Movement;
            Quaternion toRotation = Quaternion.LookRotation(Movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotspeed * Time.deltaTime);
        }

      

    }
}
