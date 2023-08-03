using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeRotationChallenge : MonoBehaviour
{
    [SerializeField] private GameObject rotatingCube;
    [SerializeField] private float cubeSpeed;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CubeRotation();
    }

    private void CubeRotation()
    {
        rotatingCube.transform.Rotate(1, 1, 1); 
          
       
    }
}
