﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;

    public Text scoreText;
    public int theScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }

   /* void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pointer")
        {
            Debug.Log("PLus");
            theScore += 10;
            scoreText.GetComponent<Text>().text = "Score: " + theScore;
            Destroy(collision.gameObject);

        }
    }*/
}
