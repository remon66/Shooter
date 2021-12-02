using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public GameObject eatParticle;

    void Start(){
        eatParticle = GameObject.Find("Eat");
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player" || other.gameObject.layer == 7){
            GameObject eatCopy = Instantiate(eatParticle, this.transform.position, Quaternion.identity);
            if(other.GetComponent<Player>().playerHealth == 10){
                Destroy(this.gameObject);
                return;
            }else{
                other.GetComponent<Player>().playerHealth++;
            }
            Destroy(eatCopy, 5f);
            Destroy(this.gameObject);
        }
    }
}
