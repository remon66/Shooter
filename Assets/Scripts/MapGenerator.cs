using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject cube;
    public GameObject parent;
    public int count = 5;

    void Start()
    {
       for (int x = 0; x < count; x++)
       {
           for (int y = 0; y < count; y++)
           {
               GameObject copy = Instantiate(cube, new Vector3(Random.Range(-40,40), 0, Random.Range(-20,20)), Quaternion.identity);
               copy.transform.localScale = new Vector3(Random.Range(2,5), Random.Range(5, 15), Random.Range(2,5));
               copy.tag = "Ground";
               copy.transform.parent = parent.transform;
               copy.transform.position = new Vector3(copy.transform.position.x, copy.transform.localScale.y / 2, copy.transform.position.z);
           }
       } 
    }
}
