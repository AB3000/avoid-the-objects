using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
