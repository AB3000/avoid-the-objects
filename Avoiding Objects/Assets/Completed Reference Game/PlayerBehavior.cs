using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{ 
    //variable tracking mouse position 
    Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //Constantly grab mouse position
        mousePosition = Input.mousePosition;

        //Remaps / ensures position is within camera visibility
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //make the player follow the mouse horizontally
        Vector2 newPosition = new Vector2(mousePosition.x,
            this.transform.position.y);

        transform.position = newPosition;
  
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Dangerous object collides with player? Game over.
        if (col.tag == "EvilObject")
        {
            SceneManager.LoadScene("Ending Screen");
        }
    }
}
