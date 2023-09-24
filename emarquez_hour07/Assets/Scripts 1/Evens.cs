using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        int sum = 0;

        while (count <= 100)
        {
            sum += count;
            count++;
        }
        Debug.Log(sum);
    }


}
