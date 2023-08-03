using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IntegerTree intTree = new IntegerTree();

        intTree.Insert(0, 1);
        intTree.Insert(1, 2);
        intTree.Insert(1, 3);
        intTree.Insert(1, 4);
        intTree.Insert(2, 5);
        intTree.Insert(2, 6);

        Debug.Log("Tree Traversal!");
        intTree.Traverse();

        GenericTree<string> genTree = new GenericTree<string>();

        genTree.Insert("Albert", "OT");
        genTree.Insert("Albert", "Tracie");
        genTree.Insert("Albert", "Charles");
        genTree.Insert("Albert", "Liliana");
        genTree.Insert("Akshay", "Andrew");
        genTree.Insert("Akshay", "Jon");

        Debug.Log("Generic Tree Traversal!");
        intTree.Traverse();
    }
}
