using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public GameObject shootingPoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            GameObject copyBullet = Instantiate(bullet, shootingPoint.transform.position, Quaternion.identity);
            copyBullet.GetComponent<Bullet>();
            Destroy(copyBullet, 5f);
        }
    }
}
