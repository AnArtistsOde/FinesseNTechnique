using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.TerrainAPI;
/// <summary>
/// tt: practicing algs: 
/// given an array of integer nums and an integer target, return indices of the two numbers 
/// such that they add up to target 
/// you may assume that each input would have exactly one solution, and you may not use the same element twice 
/// you can return the answer in any order 
/// </summary>
public class TechnicalInterviewAlgorithmExample : MonoBehaviour
{
    int[] nums = { 2, 7, 11, 15 };
    int target = 9; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($" {CalculateTwoSum(nums, target)}"); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// tt: solution using dictionaries and a complement 
    /// the nums and complement make up the dictionary 
    /// reducing the time and space complexity of o(nsquared) to O(n) 
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] CalculateTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> num = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i]; 
            if(num.ContainsKey(complement))
            {
                return new int[] { nums[i], complement, i  };
            }
            num[nums[i]] = i; 
        }
        return new int[0];
    }
} 
