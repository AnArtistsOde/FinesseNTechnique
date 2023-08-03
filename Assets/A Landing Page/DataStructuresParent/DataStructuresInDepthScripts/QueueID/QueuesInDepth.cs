using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueuesInDepth<T>
{
    List<T> queuesInDepth; 
    public QueuesInDepth()
    {
      queuesInDepth = new List<T> ();
    }

    public void Enqueue (T item)
    {
        queuesInDepth.Add (item);
    }
    public T Dequeue()
    {
        if (queuesInDepth.Count  <= 0)
        {
            Debug.LogError("Errpr! Cannot pop an empty queue"); 
        }
        T removingItem = queuesInDepth[0];
        queuesInDepth.Remove(removingItem);
        return removingItem; 
    }

    public bool IsEmpty()
    {
        return queuesInDepth.Count <= 0; 
    }
}
