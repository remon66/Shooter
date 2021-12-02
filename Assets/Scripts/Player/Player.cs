using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int playerHealth = 6;
    public Text playerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0){
            Destroy(this.gameObject);
        }
        playerHealthText.text = "Player health: " + playerHealth; 
    }
}
