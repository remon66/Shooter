using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public Camera camera;

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
        if(other.gameObject.tag == "Player" || other.gameObject.layer == 7){
            player.GetComponent<Player>().playerHealth-=2;
            Destroy(this.gameObject);
        }
    }
}
