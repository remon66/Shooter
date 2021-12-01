using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public float bulletDamage = 5f;
    public float bulletSpeed = 50f;
    public int enemiesKilled = 0;
    public GameObject player;
    public GameObject bullet;
    public Vector3 direction;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bullet = this.gameObject;
        player = GameObject.Find("Player");
        direction = player.transform.forward;
        rigidbody = this.GetComponent<Rigidbody>();
    }

    void Update(){
        if(this.gameObject != null){
            bullet.transform.position += direction * Time.deltaTime * bulletSpeed;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Obstacle"){
            Destroy(this.gameObject);
        }
    }
}