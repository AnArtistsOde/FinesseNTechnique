using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: an extremely inefficient design practice - use as last resort 
/// </summary>
public class BruteForce : MonoBehaviour
{
    private int key; 
    // Start is called before the first frame update
    void Start()
    {
        ByBruteForce(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ByBruteForce()
    {
        key = Random.Range(0, 9999);
        Debug.Log($"The key to check is: {key} and the current time passed is {Time.time}");

        // check all possiblities until key is found
        int keyCheck = 0;

        while (keyCheck != key)
        {
            keyCheck++;
        }
        Debug.Log($"Key Found is {keyCheck} at {Time.time}");
    }
}
