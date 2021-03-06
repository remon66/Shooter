using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject ground;
    public Rigidbody rigidbody;
    public float speed = 5f;
    private float desiredRot;
    public float damping = 10;
    public float rotSpeed = 250;
    public Transform to;
    
    float lastJump, timeBetweenJumps = 2.1f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = player.GetComponent<Rigidbody>();
        player = this.gameObject;
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            desiredRot -= rotSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) {
            desiredRot += rotSpeed * Time.deltaTime;
        }

 
        var desiredRotQ = Quaternion.Euler(0, desiredRot, 0);
        transform.rotation = Quaternion.Lerp(desiredRotQ, transform.rotation, Time.deltaTime * damping);

        if(Input.GetKey(KeyCode.W)){
            player.transform.position += transform.forward * Time.deltaTime * speed;         
        }
        if(Input.GetKey(KeyCode.S)){
            player.transform.position -= transform.forward * Time.deltaTime * speed;         
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            if(Time.time - lastJump > timeBetweenJumps){
                lastJump = Time.time;
                rigidbody.AddForce(new Vector3(0, 10, 0), ForceMode.VelocityChange);
            }
        }
    }
    Camera m_camera;
}
