using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Light Bulb");
    }

    public GameObject target;
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.L))
            target.SetActive(false);
        else 
            target.SetActive(true);

    }
}
