using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
/// <summary>
/// tt: 
/// </summary>
public class GraphNode : MonoBehaviour
{
    // need reference to edges node possesses
    // list keeps track of all the assigned edges 
    [HideInInspector] public List<GraphEdge> edges = new List<GraphEdge>();
    //using TMPro to easily identify edges 
    public GameObject graphNodeNameObject;
    // keep track of graph node  name 
    GameObject graphNodeName;



    private void Awake()
    {
        // add all edges connected to node to the gNN 
        graphNodeName = Instantiate(graphNodeNameObject);
        graphNodeName.GetComponent<TMP_Text>().SetText(gameObject.name); 
        // adding all the edges to the node 
        foreach(GraphEdge edge in FindObjectsOfType(typeof(GraphEdge)))
        {
            // 
            if (edge.fromNode == this  || edge.toNode == this)
            {
                edges.Add(edge);
                Debug.Log(" Added" + gameObject.name); 
            }
        }
    }




    private void Update()
    {
        // keep track of position 
        graphNodeName.transform.position = transform.position + Vector3.up * 1.2f; 
    }
}
