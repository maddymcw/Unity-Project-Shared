using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject doorCollider;
    public GameObject doorCollider2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorCollider.SetActive(true);
        doorCollider2.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorCollider.SetActive(false);
            doorCollider2.SetActive(false);
            Destroy(gameObject);
        }
        
    }
}
