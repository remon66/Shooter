using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
    public GameObject shootingPoint;
    public int strayFactor = 10;
    float lastBullet, timeBetweenBullets = 1f;
    public int bulletCount = 3;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0)){
            if(Time.time - lastBullet > timeBetweenBullets){
                lastBullet = Time.time;
                for (int i = 0; i < bulletCount; i++)
                {
                    int randomRotationX = Random.Range(-strayFactor, strayFactor);
                    int randomRotationY = Random.Range(-strayFactor, strayFactor);
                    int randomRotationZ = Random.Range(-strayFactor, strayFactor);
                    GameObject copyBullet = Instantiate(bullet, shootingPoint.transform.position, transform.rotation);
                    copyBullet.transform.Rotate(randomRotationX, randomRotationY, copyBullet.transform.position.z);
                    copyBullet.GetComponent<Rigidbody>().AddForce(copyBullet.transform.forward * 1250);
                    Destroy(copyBullet, 5f);
                }
            }
        }
    }
}
