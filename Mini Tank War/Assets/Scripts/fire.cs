using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bomb;
    public Transform spawner;
    public float bombspeed;
    float fireate;
    float nextfire;
    // Start is called before the first frame update
    void Start()
    {
        fireate =1;
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void firing()
    {
        if (nextfire < Time.time)
        {
            GameObject Bomb = Instantiate(bomb, spawner.position, bomb.transform.rotation);
            Rigidbody rb = Bomb.GetComponent<Rigidbody>();
            rb.AddForce(spawner.forward * bombspeed, ForceMode.Impulse);
           // Destroy(Bomb, 4);
           nextfire=Time.time+fireate;
        }
    }

    
}
