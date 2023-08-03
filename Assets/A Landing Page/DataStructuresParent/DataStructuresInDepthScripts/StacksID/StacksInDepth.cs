using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class StacksInDepth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CustomStacksInDepth<int> inDepthCustomStack = new CustomStacksInDepth<int> ();

        inDepthCustomStack.Push (10);
        inDepthCustomStack.Push(15);
        inDepthCustomStack.Push(20);
        inDepthCustomStack.Push(30);
        inDepthCustomStack.Push(45);
        inDepthCustomStack.Push(50);

        Debug.Log("Is the stack empty? " + inDepthCustomStack.IsEmpty());
        Debug.Log("Popping the stack" + inDepthCustomStack.Pop()); 

    }

// Update is called once per frame
    void Update()
    {
        
    }
}
