using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class posicionRandom : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject prefab;
    public float SpawnChance;
    private Vector3 spawnPosition;

    [Header("Raycast Settings")]
    public float distanceBetweenCheck;
    public float heightOfCheck = 10f, rangeOfCheck = 30f;
    public LayerMask layerMask;
    public Vector2 positivePosition, negativePosition;


    private void Start()
    {
        SpawnResources();
    }

    void SpawnResources()
    {

        for (float x = negativePosition.x; x < positivePosition.x; x += distanceBetweenCheck)
        {
            for (float z = negativePosition.y; z < positivePosition.y; z += distanceBetweenCheck)
            {
                RaycastHit hit;
                if (Physics.Raycast(new Vector3(x, heightOfCheck, z), Vector3.down, out hit, rangeOfCheck, layerMask))
                {
                    if (SpawnChance > Random.Range(0, 101))
                    {
                        Instantiate(prefab, hit.point, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);

                        //if (SpawnChance > Random.Range(0, 101))
                        //{
                            // Instanciar el objeto a una altura inicial mayor.
                           // GameObject newObject = Instantiate(prefab, spawnPosition, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
                          //  newObject.AddComponent<objetoCayendo>();
                       // }
                    }
                }
            }
        }
    }
}