using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (transform.position.z < 0)
        {
            rb.velocity = new Vector3(0, 0, 5f);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, -5f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
