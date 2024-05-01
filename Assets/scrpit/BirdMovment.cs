using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class BirdMovment : MonoBehaviour
{   
    int score=0;
    public Text scoreUI;
    Rigidbody2D bird;
    public bool isAlive;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start() 
    { 
       bird= GetComponent<Rigidbody2D>(); 
       // Set the alive to true
       isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {

            bird.AddForce(new  Vector2 (0,1) * 200);
        }
        if(isAlive == false)
        {
            GameOver();
        }

    }

     void OnTriggerEnter2D(Collider2D other)
     {
        if(other.gameObject.CompareTag("Points"))
        {
            score = score + 1;
            scoreUI.text = score.ToString();
        }

     }

     private void OnCollisionEnter2D(Collision2D other)
     {
        // Set alive to false on Collision
        isAlive = false;
     }

     public void GameOver() { 
        gameOverText.gameObject.SetActive(true);
     }

     public void RestartGame()
     {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
}   

