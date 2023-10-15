using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTriggerScript : MonoBehaviour
{
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
        print(other.gameObject.name + " has entered the right wall");
    }
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the right wall");
    }
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has exit the right wall");
    }
}
