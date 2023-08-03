using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: uses divide and conquer based on pivot 
/// </summary>
public class QuickSortAlgorithm : MonoBehaviour
{
    private int[] quickSortArray = { 5, 7, 2, 3, 6, 1, 8, 9 };
    // Start is called before the first frame update
    void Start()
    {
        PerformQuickSort(quickSortArray, 0, quickSortArray.Length);
  
        // call quick sort 
    }

    static void PerformQuickSort(int[] quickSortArray, int lowIndex, int highIndex)
    {
        // ensure lower index is lower than high index 
        if(lowIndex < highIndex)
        {
            //introduce partition index received from partition helper function
            int partitionIndex = Partition(quickSortArray, lowIndex, highIndex);

            PerformQuickSort(quickSortArray, lowIndex, partitionIndex - 1); 
            PerformQuickSort(quickSortArray, partitionIndex +1, highIndex);
        }
    }    

    static int Partition(int[] quickSortArray, int lowIndex, int highIndex)
    {
        // pivot is last number in array 
        int pivot = quickSortArray[highIndex];

        // create imaginary slot that takes in left values (left subarray)
        int i = lowIndex - 1; 

        for(int j = lowIndex; j < highIndex; j++)
        {
            if(quickSortArray[j] <= pivot)
            {
                i++;

                // swap elements
                int temp = quickSortArray[i]; 

                quickSortArray[i] = quickSortArray[j];

                quickSortArray[j] = temp; 
            }
        }
        // swap the pivot with the element at the correct position 
        int temporary2ndPivot = quickSortArray[i + 1];
        quickSortArray[i + 1] = quickSortArray[highIndex];
        quickSortArray[highIndex] = temporary2ndPivot;
        return i + 1;  

    }
}
