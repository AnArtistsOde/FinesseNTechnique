using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeforcejump : MonoBehaviour
{
    [Header("Physics Directions")]
    private Rigidbody cubeRb;
    [SerializeField] private float cubeGravityModifier;
   [SerializeField]  private float cubeRbStartingForce;
    [SerializeField] private bool cubeOnGround = true; 
    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        Physics.gravity *= cubeGravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        JumpStart(); 
    }
    /// <summary>
    /// rigidbodys in fixed update can use time.fixeddeltatime; 
    /// </summary>
    //private void FixedUpdate()
    //{
    //    JumpStart(); 
    //}
    private void JumpStart()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cubeOnGround)
        {
            cubeRb.AddForce(Vector3.up * cubeRbStartingForce, ForceMode.Impulse);
            cubeOnGround = false; 
        }
        Debug.Log("jump working");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cubeRb.AddForce(0, 0, cubeRbStartingForce, ForceMode.Force);
        }
        Debug.Log("up working"); 
        if  (Input.GetKey(KeyCode.DownArrow))
            {
                cubeRb.AddForce( 0, 0, -cubeRbStartingForce , ForceMode.Force);
            }
        Debug.Log("down working"); 
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("floor"))
        {
            cubeOnGround = true; 
        }
    }
}
