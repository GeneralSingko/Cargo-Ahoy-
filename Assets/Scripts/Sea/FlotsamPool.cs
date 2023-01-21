using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotsamPool : MonoBehaviour
{
    public static FlotsamPool pool;
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int MAX_POOLSIZE = 10;

    [SerializeField]
    private GameObject flotsamPrefab;

    private void Awake()
    {
        if(pool == null)
        {
            pool = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < MAX_POOLSIZE; i++)
        {
            GameObject obj = Instantiate(flotsamPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetFlotsam()
    {
        for(int i=0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }


}
