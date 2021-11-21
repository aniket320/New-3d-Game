using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pr : MonoBehaviour
{
    public GameObject Effect1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("floor"))
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                GameObject effet = Instantiate(Effect1, contact.point, Quaternion.identity);
                Destroy(effet, 2);
            }
            StartCoroutine(delay());
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(delay());
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
