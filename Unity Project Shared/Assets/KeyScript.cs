using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject doorCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorCollider.SetActive(false); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorCollider.SetActive(true);
            Destroy(gameObject);
        }
    }
}
