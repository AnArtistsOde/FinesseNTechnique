using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTree<T> : MonoBehaviour
{
    private GenericTreeNode<T> root;

    public GenericTree()
    {
        root = null;
    }

    public void Insert(T parentValue, T childValue)
    {
        GenericTreeNode<T> parentNode = FindNode(root, parentValue);
        if (parentNode != null)
        {
            GenericTreeNode<T> childNode = new GenericTreeNode<T>(childValue);
            parentNode.children.Add(childNode);
        }
        else if (root == null)
        {
            root = new GenericTreeNode<T>(childValue);
        }
    }

    private GenericTreeNode<T> FindNode(GenericTreeNode<T> currentNode, T value)
    {
        if (currentNode == null)
        {
            return null;
        }

        if (EqualityComparer<T>.Default.Equals(currentNode.value, value))
        {
            return currentNode;
        }

        foreach (GenericTreeNode<T> childNode in currentNode.children)
        {
            GenericTreeNode<T> foundNode = FindNode(childNode, value);
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

    private void TraverseRecursive(GenericTreeNode<T> currentNode)
    {
        if (currentNode != null)
        {
            Debug.Log(currentNode.value + " ");

            foreach (GenericTreeNode<T> child in currentNode.children)
            {
                TraverseRecursive(child);
            }
        }
    }

}

class GenericTreeNode<T>
{
    public T value;
    public List<GenericTreeNode<T>> children = new List<GenericTreeNode<T>>();

    public GenericTreeNode(T value)
    {
        this.value = value;
    }
}