using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomQueue : MonoBehaviour
{
    private void Start()
    {
        QueuesInDepth<int> ourCustomStack = new QueuesInDepth<int> ();

        ourCustomStack.Enqueue (11);
        ourCustomStack.Enqueue(22);
        ourCustomStack.Enqueue(33);
        ourCustomStack.Enqueue(44);
        Debug.Log("Is the queue emptu?" + ourCustomStack.IsEmpty()); 
        Debug.Log("Popping the queue!" + ourCustomStack.Dequeue());
        Debug.Log("Popping the queue!" + ourCustomStack.Dequeue());
        Debug.Log("Popping the queue!" + ourCustomStack.Dequeue());
        Debug.Log("Popping the queue!" + ourCustomStack.Dequeue());

    }
}
