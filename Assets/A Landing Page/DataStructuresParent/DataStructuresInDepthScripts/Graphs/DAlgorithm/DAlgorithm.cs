using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt:   
/// </summary>
public class DAlgorithm : MonoBehaviour
{
    public List<GraphNode> nodes = new List<GraphNode>();

    public GraphNode startNode;
    public GraphNode targetNode;

    public LineRenderer pathLine;


    Dictionary<GraphNode, float> distance = new Dictionary<GraphNode, float>();
    Dictionary<GraphNode, GraphNode> previousNodes = new Dictionary<GraphNode, GraphNode>(); 
    private void Awake()
    {
        // adding all the nodes to the list 
        foreach (GraphNode node in FindObjectsOfType(typeof(GraphNode))) 
        {
            nodes.Add(node); 
        }
    }
    private void Update()
    {
        // guard clause 
        if (startNode == null || targetNode == null) return;
        CalculateDAlg(); 
    }

    public void CalculateDAlg()
    {
        // Initialize the distances and previous Nodes 
        foreach(GraphNode node in nodes)
        {
            distance[node] = float.MaxValue;
            previousNodes[node] = null; 
        }
        // Distance from the start node to itself is 0 
        distance[startNode] = 0; 

// create priority queue for storing nodes to visit
List<GraphNode> unvisitedNodes= new List<GraphNode>(nodes);
        while (unvisitedNodes.Count > 0)
        {
            // Find node with the smallest distance 
            GraphNode currentNode = null; 
            foreach( GraphNode node in unvisitedNodes)
            {
                if(currentNode == null || distance[node] < distance[currentNode])
                {
                    currentNode = node; 
                }
            }
            unvisitedNodes.Remove(currentNode);
            //Update distance to neighbouring nodes 
            foreach(GraphEdge edge in currentNode.edges)
            {
                float updateDistances = distance[currentNode] + edge.cost;

                // Choose the proper node 
                GraphNode neighbourNode = currentNode == edge.fromNode ? edge.toNode : edge.fromNode; 
          if(updateDistances < distance[neighbourNode])
                {
                    distance[neighbourNode] = updateDistances;
                    previousNodes[neighbourNode] = currentNode; 
                }
            
            }
        }
        // Draw line across  shortest path distance 
        List<GraphNode> path = new List<GraphNode>();
        GraphNode pathNode = targetNode;

        while (pathNode = targetNode) ; 
        while(pathNode != null)
        {
            path.Insert(0, pathNode); 
            pathNode = previousNodes[pathNode];
        }
        pathLine.positionCount = path.Count; 

        for(int i  = 0; i < path.Count; i++)
        {
            pathLine.SetPosition(i, path[i].transform.position); 
        }
    }






}
