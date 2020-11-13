using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeBehaviour : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject cone;

    private void OnTriggerEnter(Collider other)
    {
        if (cylinder.activeSelf)
        {
            cylinder.SetActive(false);
            cone.SetActive(true);
        }
        else
        {
            cone.SetActive(false);
            cylinder.SetActive(true);
        }    
    }
}
