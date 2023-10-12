using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yMovement = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xMovement, 0f, yMovement);

        
    }
}
