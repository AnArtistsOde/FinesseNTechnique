using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsInDepth : MonoBehaviour
{
    List<int> integerList;

    //initialize an existing List with reference 
    List<DataHolderInDepth> dataHolderInDepths = new List<DataHolderInDepth>();

    private void Start()
    {
        InitializeList();
    }
    private void Update()
    {
      
    }

    /// <summary>
    /// tt:  initializing a list within the current class 
    /// </summary>
    private void InitializeList()
    {
        //initialize existing list in class 
        integerList = new List<int>();
    }

    /// <summary>
    /// tt:  instructions on how to cast a  float var to int list 
    /// </summary>
    private void CastFloatToIntList()
    {
        //if you needed to cast a float value into an int list this is how! 
        integerList.Add((int)2.0f);
    }

    /// <summary>
    ///  tt: adding to a list and expanding the capacity at a random range via keycode.
    /// </summary>
    private void  GetListLengthAndAddToList()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            integerList.Add(Random.Range(0, 8));

            Debug.Log($"The length of the list is {integerList.Count} and the capacity after adding to the list is  {integerList.Capacity}");

        }
    }
    /// <summary>
    /// tt: removing from a list using a defined value via keycode.  
    /// </summary>
    private void GetListLengthAndRemoveFromList()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            // goes through entire list and checks if there is a matching value and removes it, otherwise returning false 
            integerList.Remove(2);
            // removing at a certain index position 
            integerList.RemoveAt(2); 
            Debug.Log($"The length of the list is {integerList.Count} and the capacity after removing from the list is   {integerList.Capacity}");
        }
    }
}
