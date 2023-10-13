using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirY, -dirX, 0);
        CheckForRaycastHit();
    }

    private void CheckForRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " hit the cube!");
            score = score + 1;
        }
    }

}
