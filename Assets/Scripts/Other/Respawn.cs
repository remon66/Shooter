using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        Debug.Log("ground");
        if(other.gameObject.layer == 7){
            other.transform.position = new Vector3(0,6,0);
        }
    }
}
