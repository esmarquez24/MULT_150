using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnValues;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Vector3 spawnposition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0f, -5f);
            GameObject gameObject = Instantiate<GameObject>(prefab, spawnposition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        whenever we hit the B key we will generate a prefab at the position of the original prefab
        whenever we hit the space key, we will generate a prefab at the position of the spawn object that this script is attached to 
        */
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
