using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameList : MonoBehaviour
{
   [SerializeField] private  List<string> nameList;

/// <summary>
/// tt: intialize list on start 
/// </summary>
    void Start()
    {
        //nameList =  new List<string> ();
    }

    // Update is called once per frame
    void Update()
    {
        AddNameToList();
        RemoveNameFromList ();
    }

    /// <summary>
    /// tt:  Adding random range capacity expansion to list of strings 
    /// </summary>
    private void AddNameToList()
    {
        if(Input.GetKeyUp(KeyCode.N))
        {
            int vInt = Random.Range(0, 4); 
            float vFloat = vInt;
            nameList.Add(vFloat.ToString());
            Debug.Log($"The length of the list is {nameList.Count} and the capacity after adding to the list is  {nameList.Capacity}");
        }
    }

    /// <summary>
    /// tt:  practicing name list removal functions 
    /// </summary>
    private void RemoveNameFromList()
    {
        if (Input.GetKeyUp(KeyCode.L))
        {
            // goes through entire list and checks if there is a matching value and removes it, otherwise returning false 
            nameList.Remove("Ye Tarnished");
            Debug.Log($"The length of the list is {nameList.Count} and the capacity after removing from the list is   {nameList.Capacity}");
        }

        if(Input.GetKeyUp(KeyCode.I))
        {
            // removes at a certain index position 
            nameList.RemoveAt(2); 
        }
    }
}
