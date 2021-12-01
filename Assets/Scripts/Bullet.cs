using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletDamage = 5f;
    public float bulletSpeed = 50f;
    public GameObject player;
    public GameObject bullet;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        bullet = this.gameObject;
        player = GameObject.Find("Player");
        direction = player.transform.forward;
    }

    void Update(){
        if(this.gameObject != null){
            bullet.transform.position += direction * Time.deltaTime * bulletSpeed;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Enemy"){
            Destroy(other);
        }
    }
}
