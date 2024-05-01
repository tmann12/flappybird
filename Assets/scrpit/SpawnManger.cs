using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject pipePrefab;
    float lowHeight = -5.45f;
    float highHeight = -1.85f;
    BirdMovment birdScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2.0f, 3.0f);
        birdScript = GameObject.Find("Red_Bird_1").GetComponent<BirdMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        if(birdScript.isAlive == false)
        {
            CancelInvoke();
        }
    }

    void SpawnPipes()
        {   
            Instantiate(pipePrefab, new Vector2 (20, Random.Range(lowHeight, highHeight)), Quaternion.identity);
        }

}
