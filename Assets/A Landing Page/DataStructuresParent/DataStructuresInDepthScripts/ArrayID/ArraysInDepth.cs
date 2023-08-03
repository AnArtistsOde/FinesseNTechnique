using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysInDepth : MonoBehaviour
{
    //Declare Arrays
    int[] integerArrays;
    string[] stringArray;
    float[] floatArray;

    DataHolderInDepth[] dataHolderInDepths; 
    // Start is called before the first frame update
    void Start()
    {
        CreatePrimitiveArrays();
        UpdateArrayValue();
        CreateCustomArray(); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// printing info - reading arrays 
    /// </summary>
    public void CreatePrimitiveArrays()
    {
        integerArrays = new int[5];
        for (int i = 0; i < integerArrays.Length; i++)
        {
            Debug.Log("Integer value is " + integerArrays[i]);
        }
        integerArrays = new int[4]  {  1,  2,  3, 4 };

        for (int i = 0; i < integerArrays.Length;  i++)
        {
            Debug.Log("Integer value after second array is " + integerArrays[i]); 
    
        }

        // this doesnt return a NRE because the array just saves string slots 
        stringArray = new string[5];
        for (int i = 0; i < stringArray.Length; i++)
        {
            Debug.Log("Integer value after second array is " + stringArray[i]); 
                stringArray = new string[] { "hello", "world" }; 
        }
    }
    /// <summary>
    /// setting arrays 
    /// </summary>
    public void UpdateArrayValue()
    {
        // the below implementation will lead to out of bounds error in array 
        //integerArrays[0] = 15;

        // we are able to find 15 because there are 20 slots initialized 
        integerArrays = new int[20];
        integerArrays[15] = 0; 
    }
    /// <summary>
    /// 
    /// </summary>
    public void CreateCustomArray()
    {
        dataHolderInDepths = new DataHolderInDepth[4]; 

        DataHolderInDepth data1 = new DataHolderInDepth();
        dataHolderInDepths[0] = data1;
        data1.id = 20; 
 
    }
}