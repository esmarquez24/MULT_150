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
            if (i < 6 || i > 6)
            {
                Debug.Log(i);
            } 
            else
            {
                for (int n =1; n <= 30; n++)
                {
                    if (n == 24)
                    {
                        print("It's my birthday!");
                    }
                    else
                    {
                        Debug.Log(n);
                    }
                }
            }
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
