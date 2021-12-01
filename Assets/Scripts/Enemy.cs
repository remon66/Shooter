using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public GameObject player;

    void Start(){
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = player.transform.position;
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Bullet"){
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

        if(other.gameObject.tag == "Player" || other.gameObject.layer == 7){
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
