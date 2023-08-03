using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ElectricCarOverride : GasolineCarOverride
{
    [SerializeField] private float electricity;
    [SerializeField] private float electricityDistance;
    private float electricitypermile; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculationTable(); 
    }
    public override void CalculationTable()
    {
        // this uses the calculation for gas per mile,
        // yet implements the values for these variables in the electric car override inspector, yielding the second result on space
        base.CalculationTable(); 
        // this returns the new implementation for the electric car  
       if(Input.GetKeyDown(KeyCode.B))
        { electricitypermile = electricity / electricityDistance;
            Debug.Log($"The cost per mile for electricity is {electricitypermile}"); 
        }
    
    }
}
