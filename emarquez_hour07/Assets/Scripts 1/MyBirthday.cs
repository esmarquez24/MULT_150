using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 12;

        for (int i = 1; i <= count; i++)
        {
            Debug.Log(i);

            if (i == 6)
            {
                print("It's my birthday!");
            }
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
