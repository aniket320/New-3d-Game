using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looat : MonoBehaviour
{
    public Joystick look;
    float a, b;

    public fire Detect;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
       a = look.Horizontal;
       b = look.Vertical;

        Vector3 Look = new Vector3(a, 0, b);
        Look.Normalize();

        if (Look != Vector3.zero)
        {
            transform.forward = Look;
        }
        if (look.Horizontal >= .3f)
        {
            Detect.firing();
        } 
        else if (look.Horizontal <= -.3f)
        {
            Detect.firing();
        }
        if (look.Vertical >= .3f)
        {
            Detect.firing();
        }
        if (look.Vertical <= -.3f)
        {
            Detect.firing();
        }

    }

   
}
