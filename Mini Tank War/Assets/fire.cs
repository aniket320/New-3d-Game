using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bomb;
    public Transform spawner;
    public float bombspeed;
    float closedis = 4;
    float close = 2;
    public GameObject[] enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (closedis <= close)
        {
            Invoke("firing", 1);
        }
      
    }


    public void firing()
    {
        GameObject Bomb = Instantiate(bomb, spawner.position, bomb.transform.rotation);
        Rigidbody rb = Bomb.GetComponent<Rigidbody>();
        rb.AddForce(spawner.forward * bombspeed, ForceMode.Impulse);
        Destroy(Bomb, 4);
    }

    void look()
    {
    }
}
