using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public int health = 3;
    private Rigidbody rb;
    public GameObject explosion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(3f, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            health -= 1;
            if (health <= 0)
            {
                FindObjectOfType<GameSession>().IncreaseGoal(1);
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                FindObjectOfType<GameSession>().Hitted();
            }
        }
    }
}
