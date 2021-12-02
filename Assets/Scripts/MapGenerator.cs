using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject cube;
    public GameObject parent;
    public int max = 30;
    public float timer = 2f;

    void Update(){
        timer -= Time.deltaTime;
        if(timer <= 0){
            spawnObstacles();
            timer = 2f;
        }else{
            return;
        }
    }

    void spawnObstacles(){
        if(parent.transform.childCount < max){
            for (int i = 0; i < 5; i++)
            {
                GameObject copy = Instantiate(cube, new Vector3(Random.Range(-40,40), 0, Random.Range(-20,20)), Quaternion.identity);
                copy.transform.localScale = new Vector3(Random.Range(2,5), Random.Range(5, 15), Random.Range(2,5));
                copy.transform.parent = parent.transform;
                copy.transform.position = new Vector3(copy.transform.position.x, copy.transform.localScale.y / 2, copy.transform.position.z);   
            }
        }else{
            GameObject firstChild = parent.transform.GetChild(0).gameObject;
            Destroy(firstChild);
        }
    }
}
