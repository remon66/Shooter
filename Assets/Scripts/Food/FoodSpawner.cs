using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject player;
    public GameObject apple;
    public float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }else{
            GameObject copy = Instantiate(apple, new Vector3(Random.Range(-40,40), 1, Random.Range(-20,20)), Quaternion.identity);
            timer = 2;
        }
    }
}
