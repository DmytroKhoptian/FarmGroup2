using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ObjectPoolerSimple : MonoBehaviour
{
    public static ObjectPoolerSimple objectPooler;
    [SerializeField] private GameObject pooledObject;
    [SerializeField] private List<GameObject> pooledObjects;
    [SerializeField] private int poolSize;
    [SerializeField] private bool willGrow;


    private void Awake()
    {
        objectPooler = this;
        pooledObjects = new List<GameObject>();
    }


    void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            pooledObjects.Add(Instantiate(pooledObject));
            pooledObjects[i].transform.SetParent(transform);
            pooledObjects[i].SetActive(false);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            obj.transform.SetParent(transform);
            return obj;    
        }

        return null;
    }
}
