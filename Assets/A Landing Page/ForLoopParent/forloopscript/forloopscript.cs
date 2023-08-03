using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class forloopscript : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject[] cubesmoves;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CubeLoop(); 
    }

    private void CubeLoop()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Loop through each object in the array and move it
            for (int i = 0; i < cubesmoves.Length; i++)
            {
                // Get the current object
                GameObject currentObject = cubesmoves[i];

                // Move the object based on its current position and move speed
                currentObject.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
                Debug.Log("Cubes working"); 
            }
        }

    }
}
