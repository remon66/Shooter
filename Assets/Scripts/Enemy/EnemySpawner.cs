using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float timer = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime;
        }else{
            GameObject copy = Instantiate(enemyPrefab, new Vector3(Random.Range(-40,40), 0, Random.Range(-20,20)), Quaternion.identity);
            timer = 2;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Obstacle"){
            Destroy(this.gameObject);
            timer = 0.1f;
            Debug.LogWarning("Enemy Deleted!");
        }
    }
}
