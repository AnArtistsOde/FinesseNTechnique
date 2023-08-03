using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// tt: brute force approach 
/// </summary>
public class FindEnemyWithList : MonoBehaviour
{
    public Transform playerTransform;
    public List<Transform> enemyTransforms;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindClosestEnemy(playerTransform).name); 
    }
    /// <summary>
    /// tt: loop through all enemies avail, 
    /// </summary>
    /// <returns></returns>
    public Transform FindClosestEnemy(Transform playerTransform ) 
    {
        Transform closestEnemy  = null;
        float closestDistance = float.MaxValue;
        foreach (Transform enemyTransform in enemyTransforms)
        {
            float distanceToEnemy = Vector3.Distance(playerTransform.position, enemyTransform.position);

            if (distanceToEnemy < closestDistance)
            {
                closestDistance = distanceToEnemy;
                closestEnemy = enemyTransform;
                Debug.Log($" closest enemy is {closestEnemy.name} and the distance to enemy is {closestDistance}");


            }
        }
        return closestEnemy;
    }
}
