using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    [SerializeField] private List<Rigidbody> cubeArrayRigidBodies;
    private float destroyCubeDelay = 2f; 
    /// <summary>
    ///  When a key is pressed, a random cube in the array will have a force heading right, then will be destroyed and removed from the list
    /// </summary>
    private void ArrayChallenge()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            // a local variable is created to set the random range for the list
            int luckyNumber = Random.Range(0, cubeArrayRigidBodies.Count);
            // a force is applied 
            cubeArrayRigidBodies[luckyNumber].AddForce(Vector3.right);
            // destroy the game object , with a destroy delay
            Destroy(cubeArrayRigidBodies[luckyNumber].gameObject, destroyCubeDelay);
            // remove the cube from the list of rigidbodies 
            cubeArrayRigidBodies.RemoveAt(luckyNumber);
            Debug.Log($" the process is complete"); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        ArrayChallenge(); 
    }
}
