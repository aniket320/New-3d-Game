using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    float X, Z;
    public Joystick controller;
    public float speed;
    public float rotspeed;
    public float health;
    public Slider healthbar;
    public GameObject left; 
    public GameObject right;
   
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
            transform.forward = Movement*rotspeed;
        }

        if (player.velocity.magnitude > 0)
        {
            left.SetActive(true);
            right.SetActive(true);
        }
        else 
        {
            left.SetActive(false);
            right.SetActive(false);
        }

        healthbar.value = health;
        
     
        
    }

    private void OnTriggerEnter(Collider stuck)
    {
        if (stuck.gameObject.CompareTag("stucker"))
        {
            speed = 0.1f;

        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("stucker"))
        {
            speed = 0.5f;
        }
    }
}
