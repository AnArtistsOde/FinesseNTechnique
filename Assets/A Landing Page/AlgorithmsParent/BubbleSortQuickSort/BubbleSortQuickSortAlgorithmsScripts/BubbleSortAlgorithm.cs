using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
/// <summary>
///tt:   bubble sort compares two values, the higher value gets put into a temporary location whilst the lower value is moved to the index position
///  the greater value previously held, the bubble then compares the next two numbers - rinse and repeat ,
///  bubble sorts are best for small data sets 
/// </summary>
public class BubbleSortAlgorithm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] inputArray = { 5, 7, 2, 3, 6, 1, 8, 9 };
        PerformBubbleSort( inputArray); 
        string arrayValue = ""; 
        for (int i = 0; i < inputArray.Length; i++)
        {
            arrayValue += inputArray[i] + " , "; 
        }
        Debug.Log($"The array is { arrayValue}");
    }

  static  void PerformBubbleSort(int[] inputArray)
    {
        bool swapped; 
        // loop through entire length 
        for(int i = 0; i < inputArray.Length; i++)
        {
            // set boolean to false
            swapped = false; 
            // go through elements  and check the small array of two I and J 
             for(int j= 0;   j< inputArray.Length - i -1; j++)
            {
                if (inputArray[j] > inputArray[j+1])
                {
                    int temp = inputArray[j]; 
                    inputArray[j] = inputArray[j+1];
                    inputArray[j + 1] = temp;
                    // each time swapped set swap to true 
                    swapped = true; 
                }
            }
             // a check to see if  anything was swapped if not break 
             if (!swapped)
            {
                break; 
            }
        }
    }
}
