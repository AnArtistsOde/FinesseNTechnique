using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: overrides script 1/2
/// </summary>
public class GasolineCarOverride : MonoBehaviour
{
   [SerializeField]private float gasoline;
    [SerializeField]private float gasolineDistance;
    private float gaspermile; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculationTable(); 
    }

    public virtual void CalculationTable()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            gaspermile = gasoline * gasolineDistance;
            Debug.Log($" the cost for gaspermile is {gaspermile}");
        }
    }
}
