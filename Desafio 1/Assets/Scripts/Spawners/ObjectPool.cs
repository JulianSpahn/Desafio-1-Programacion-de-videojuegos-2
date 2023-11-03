using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int poolSize = 5;
    [SerializeField] private GameObject objectPrefab1;
    [SerializeField] private int poolSize1 = 5;

    private List<GameObject> pooledObjects;
    private List<GameObject> pooledObjects1;
    void Start()
    {
        pooledObjects = new List<GameObject>();
        pooledObjects1= new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
        for (int i = 0; i < poolSize1; i++)
        {
            GameObject obj1 = Instantiate(objectPrefab1);
            obj1.SetActive(false);
            pooledObjects1.Add(obj1);
        }
    }

    public GameObject GetPooledObject()
    {
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }
    public GameObject GetPooledObject1()
    {
        foreach (GameObject obj in pooledObjects1)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        return null;
    }
}
