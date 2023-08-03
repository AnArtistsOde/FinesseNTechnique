//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FindEnemyWithBinarySearch : MonoBehaviour
//{
//    public Transform playerTransform;
//    public List<Transform> enemyTransforms;
//    BinarySearchTree searchTree;
//    Start is called before the first frame update
//    void Start()
//    {
//        searchTree = new BinarySearchTree();
//        foreach (Transform enemyTransform in enemyTransforms)
//        {
//            float distanceToEnemy = Vector3.Distance(playerTransform.position, enemyTransform.position);
//            searchTree.Insert(distanceToEnemy, enemyTransform);
//        }
//        Debug.Log($"The closest key is {FindClosestEnemy().name}");
//    }

//    public Transform FindClosestEnemy()
//    {
//        float closestDistancde = searchTree.FindMinKey();
//        return searchTree.FindTransformValue(closestDistancde);

//    }
//}
