using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float bulletDamage = 5f;
    public float bulletSpeed = 50f;
    public GameObject player;
    public GameObject bullet;
    public GameObject bloodParticle;
    public Gun gun;
    public Vector3 direction;
    public Rigidbody rigidbody;
    public Text enemiesKilledText;

    // Start is called before the first frame update
    void Start()
    {
        bullet = this.gameObject;
        player = GameObject.Find("Player");
        gun = GameObject.Find("Gun").GetComponent<Gun>();
        direction = player.transform.forward;
        rigidbody = this.GetComponent<Rigidbody>();
        bloodParticle = GameObject.Find("Blood");
        enemiesKilledText = GameObject.Find("killedEnemies").GetComponent<Text>();
        enemiesKilledText.text = "Enemies killed: " + gun.enemiesKilled;
    }

    void Update(){
        if(this.gameObject != null){
            bullet.transform.position += direction * Time.deltaTime * bulletSpeed;
        }
        enemiesKilledText.text = "Enemies killed: " + gun.enemiesKilled;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Obstacle"){
            Destroy(this.gameObject);
        }

        if(other.gameObject.tag == "Enemy"){
            Debug.LogError("fff");
            gun.enemiesKilled++;
            GameObject particle = Instantiate(bloodParticle, other.gameObject.transform.position, Quaternion.identity);
            Destroy(particle, 1f);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}