using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantScript : MonoBehaviour
{
    public GameObject chillie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Chillie SeedBag")
        {
            Destroy(other.gameObject);
            spawnplant();
        }
    }

    void spawnplant()
    {
        Instantiate(chillie, transform.position, transform.rotation);
    }
}
