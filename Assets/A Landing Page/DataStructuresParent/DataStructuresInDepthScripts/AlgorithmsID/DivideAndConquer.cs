using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivideAndConquer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 5, 7, 2, 3, 6, 1, 8, 9 };
       MinMax minMax = FindMinMax(array, 0, array.Length - 1);
        Debug.Log($"Min: {minMax.min} and Max: {minMax.max}"); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static MinMax FindMinMax(int[] array, int low, int high)
    {
        if (high - low == 1) // Array has  two elements 
        {
            return new MinMax(Mathf.Min(array[low], array[high]), Mathf.Max(array[low], array[high]));
        }
        else if ( high == low) // Array has one element
        {
            return new MinMax(array[low], array[low]);
        }
        else
        {
            int mid = (low + high) / 2; 
            // Find minmax within each half using recursion 
            MinMax left = FindMinMax(array, low, mid);
            MinMax right = FindMinMax(array, mid + 1, high);

            // Compare the min and max of both sides 
            return new MinMax(Mathf.Min(left.min, right.min), Mathf.Max(left.max, right.max));
        }
    }
}

public struct MinMax
{
    public int min;
    public int max; 
    public MinMax(int min, int max)
    {
        this.min = min;
        this.max = max; 

    }
 
}
