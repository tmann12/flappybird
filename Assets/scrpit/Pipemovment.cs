using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemovment : MonoBehaviour
{
    public float speed;
    BirdMovment birdScript;
    // Start is called before the first frame update
    void Awake()
    {
        birdScript = GameObject.Find("Red_Bird_1").GetComponent<BirdMovment>();
    }
 
    // Update is called once per frame
    void Update()
    {
         if(birdScript.isAlive == true)
        {
            //  Move pipes left
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }
}
