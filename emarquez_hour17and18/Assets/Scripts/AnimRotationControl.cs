using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimRotationControl : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // Get a reference to the animator
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetTrigger("Rotation");
        }
    }
}
