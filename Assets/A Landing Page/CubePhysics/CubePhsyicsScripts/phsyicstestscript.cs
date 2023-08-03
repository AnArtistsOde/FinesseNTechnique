using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phsyicstestscript : MonoBehaviour
{
  [SerializeField] private Rigidbody cubePhysicsTestRB;
    [SerializeField] private float cubeExplosion;
    [SerializeField] private Vector3 cubeVector3;
    [SerializeField] private float cubeExplosionRadius; 
    // Start is called before the first frame update
    void Start()
    {
        cubePhysicsTestRB.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PhysicsTesting123(); 
    } 

    private void PhysicsTesting123()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            cubePhysicsTestRB.AddExplosionForce(cubeExplosion, cubeVector3, cubeExplosionRadius);

        }
    }
}
