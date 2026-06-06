using System;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject targetPrefab;
    public float minDistance = 10f;
    Transform[]targetPositions;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPositions = GetComponentsInChildren<Transform>();
    }

    public void GenerateTarget(Vector3 PlayerPosition)
    {
        int index;
        do
        {
            index = Random.Range(1, targetPositions.Length);
        }while(Vector3.Distance(PlayerPosition, targetPositions[index].position) < minDistance);

        Vector3 position = targetPositions(targetPrefab, position, Quaternion.identity);
        targetPositions.transform.SetParent(transform);
    }
}
