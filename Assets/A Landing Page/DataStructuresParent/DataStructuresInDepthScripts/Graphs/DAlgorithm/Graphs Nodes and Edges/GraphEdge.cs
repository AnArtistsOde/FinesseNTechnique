using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
[RequireComponent(typeof(LineRenderer))]
public class GraphEdge : MonoBehaviour
{
    public GraphNode fromNode, toNode;
    public float cost;
    public GameObject costTextObject;

    private GameObject costText;
    private LineRenderer edgeLine;

    private void Start()
    {
        //CalculateCosts(); 
        costText = Instantiate(costTextObject);
        edgeLine = GetComponent<LineRenderer>();
        edgeLine.positionCount = 2;
    }
    private void Update()
    {
        //CalculateCosts();
        cost = Vector3.Distance(fromNode.transform.position, toNode.transform.position);
        DrawEdgeLine();
        costText.GetComponent<TMP_Text>().SetText(" " + cost);
    }


    private void DrawEdgeLine()
    {
        edgeLine.SetPosition(0, fromNode.transform.position);
        edgeLine.SetPosition(1,  toNode.transform.position);
        // 2 is get middle  1.2f is linesize 
        costText.transform.position = (fromNode.transform.position + toNode.transform.position) / 2 + Vector3.up * 1.2f; 
    }

    private void CalculateCosts()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            costText = Instantiate(costTextObject);
            edgeLine = GetComponent<LineRenderer>();
            edgeLine.positionCount = 2;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            cost = Vector3.Distance(fromNode.transform.position, toNode.transform.position);
            DrawEdgeLine();
            costText.GetComponent<TMP_Text>().SetText(" " + cost);
        }
    }
}
