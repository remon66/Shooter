using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public GameObject shootingPoint;
    float lastBullet, timeBetweenBullets = 0.25f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0)){
            if(Time.time - lastBullet > timeBetweenBullets){
                lastBullet = Time.time;
                GameObject copyBullet = Instantiate(bullet, shootingPoint.transform.position, Quaternion.identity);
                Destroy(copyBullet, 5f);
            }
        }
    }
}
