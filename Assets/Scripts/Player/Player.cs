using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int playerHealth = 6;
    public Text playerHealthText;
    public int enemiesKilled;

    Camera camera = Camera.main;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0){
            Destroy(this.gameObject);

            SceneManager.LoadScene(0);
        }
        playerHealthText.text = "Player health: " + playerHealth; 
    }
}
