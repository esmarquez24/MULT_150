using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") / 10;
        float mY = Input.GetAxis("Mouse Y") / 10;
        transform.Translate(mX, mY, 0);
        // transform.Translate(transform.position.x + mX, transform.position.y + mY, transform.position);
    }
}
