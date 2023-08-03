using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: dictionaries are type safe and optimized for c# usage 
/// </summary>
public class DictionariesInDepth : MonoBehaviour
{
    Dictionary<string, int> highScores = new Dictionary<string, int>(); 
    // Start is called before the first frame update
    void Start()
    {
        AddDataToDictionary();
        CheckIfKeyAvailable(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// tt: adding data to dictionary 
    /// </summary>
    private void AddDataToDictionary()
    {
        highScores.Add("Lemonade", 255);
        highScores.Add("Cranberry", 406);
        highScores.Add("Pineapple", 26); 
    }
    /// <summary>
    ///  tt: checking if key available and returning the found value through  debug 
    /// </summary>
    private void CheckIfKeyAvailable()
    {
        if(highScores.ContainsKey("Lemonade"))
        {
            Debug.Log("Lemonade has a value of" + highScores["Lemonade"]); 
        }
        else
        {
            Debug.Log("Nothing has been found"); 
        }
    }
}
