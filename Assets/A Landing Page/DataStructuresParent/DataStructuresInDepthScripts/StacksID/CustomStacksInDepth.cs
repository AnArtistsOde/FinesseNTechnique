using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.UIElements;
using UnityEngine;
/// <summary>
/// tt: converted into generic class data type , taking any shape or form of data type 
/// </summary>
/// <typeparam name="T"></typeparam>
public class CustomStacksInDepth<T>
{
    // tt: step 1 utilize list as base data structure 
    List<T> customStack; 
    // use public constructor for customstack reference use 
public CustomStacksInDepth()
    {
        customStack = new List<T>();
        Debug.Log("Initialized a new stack!"); 
    }
   
    
    /// <summary>
    /// constructor 
    /// </summary>
    public int Count
    {
        get { return customStack.Count; }
    }
    // pushing our first plate onto our stack table , taking in our item we want to push 
    public void Push(T item)
    {
        customStack.Insert(0, item);
    }

    // returning the pushed item 

    public T Pop()
    {
        if(customStack.Count <= 0)
        {
            Debug.LogError("Error! Cannot pop an empty stack! xoxo"); 
        }
        T removingItem = customStack[0];
        customStack.Remove(removingItem);
        return removingItem; 
    }

    public bool IsEmpty()
    {
        return customStack.Count <= 0; 
    }
    
}
