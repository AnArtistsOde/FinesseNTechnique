using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBackAndForth : MonoBehaviour
{
    [SerializeField] private  GameObject cube;
    [SerializeField] private float backandForthSpeed; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BackAndForth(); 
    }
    /// <summary>
    /// based on key pressed, back or forth motion is recorded
    /// </summary>
    private void BackAndForth()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back);

        }
    }

}
