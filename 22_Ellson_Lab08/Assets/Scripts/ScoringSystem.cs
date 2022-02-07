using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{

    public Text scoreText;
    public int theScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("PLus");
            theScore += 10;
            scoreText.GetComponent<Text>().text = "Score: " + theScore;
            Destroy(collision.gameObject);

        }
    }
}
