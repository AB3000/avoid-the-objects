using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DangerousObjectBehavior : MonoBehaviour
{

    //Score tracker: How many objects have been avoided?
    public static float objectsAvoided;
    public TextMeshProUGUI textMeshPro;


    // Start is called before the first frame update
    void Start()
    {
        objectsAvoided = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        //Object has made it past the player
        if(col.tag == "Collider")
        {
            // randomly respawn this
            // Camera horzinotal range: roughly -7.0 to 7.0
            // Vertical spawn height: 7.0f 
            transform.position = new Vector2(Random.Range(-7.0f, 7.0f), 7.0f);

            //Reset object velocity (try removing this line and see what happens!)
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);

            //Randomly set gravity scale to impact falling speed of object
            GetComponent<Rigidbody2D>().gravityScale = Random.Range(0.5f, 3.0f);

            //Increase score count, update display on screen
            objectsAvoided++;
            textMeshPro.text = "Score: " + objectsAvoided;

        }
    }
}
