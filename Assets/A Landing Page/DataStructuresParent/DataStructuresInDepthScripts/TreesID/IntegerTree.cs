using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt:  a hierarchical data storage structure for ease of navigation,. 
/// trees comprise a collection of nodes that are connected via 
/// a hierarchical (parent/child) relationship of edges 
/// Root: start of tree and the very first node with no parent. 
/// Child: immediate successor of another node 
/// Leaf nodes: nodes with parents and no children (bottom of the tree)
/// Tree height: length from root node to last leaf node. 
/// Siblings: children of the same parent node
/// Subtree- a node of a tree with descendants. 
/// Edge: connection between parent and child node. 
/// Use cases: skill tree, game scenes, decisions 
/// </summary>
public class IntegerTree
{
    private IntegerTreeNode root;

    public IntegerTree()
    {
        root = null;
    }

    public void Insert(int parentValue, int childValue)
    {
        IntegerTreeNode parentNode = FindNode(root, parentValue);
        if (parentNode != null)
        {
            IntegerTreeNode childNode = new IntegerTreeNode(childValue);
            parentNode.children.Add(childNode);
        }
        else if (root == null)
        {
            root = new IntegerTreeNode(childValue);
        }
    }

    private IntegerTreeNode FindNode(IntegerTreeNode currentNode, int value)
    {
        if (currentNode == null)
        {
            return null;
        }

        if (currentNode.value == value)
        {
            return currentNode;
        }

        foreach (IntegerTreeNode childNode in currentNode.children)
        {
            IntegerTreeNode foundNode = FindNode(childNode, value);
            if (foundNode != null)
            {
                return foundNode;
            }
        }

        return null;
    }

    public void Traverse()
    {
        TraverseRecursive(root);
    }

    private void TraverseRecursive(IntegerTreeNode currentNode)
    {
        if (currentNode != null)
        {
            Debug.Log(currentNode.value + " ");

            foreach (IntegerTreeNode child in currentNode.children)
            {
                TraverseRecursive(child);
            }
        }
    }
}

class IntegerTreeNode
{
    public int value;
    // with each child it will also have its own value and children, initialized  
    public List<IntegerTreeNode> children = new List<IntegerTreeNode>();
    /// <summary>
    /// tt:/ constructor to set our values when we construct a new integer tree node 
    /// </summary>
    /// <param name="value"></param>
    public IntegerTreeNode(int value)
    {
        this.value = value;
    }
}

