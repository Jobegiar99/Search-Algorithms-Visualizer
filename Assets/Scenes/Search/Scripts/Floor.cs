using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update
    public string type;

    private void OnMouseDown()
    {
        controller control = GameObject.Find("Controller").GetComponent<controller>();
        GetComponent<SpriteRenderer>().sprite = control.sprites[control.selectedSpriteIndex];
        type = control.selectedFloorType;
        if( type == "Goal")
        {
            if(control.goal != null){
                control.goal.GetComponent<SpriteRenderer>().sprite = control.sprites[0];
                control.goal.GetComponent<Floor>().type = "Normal";
                control.goal = gameObject;
            }else
            {
                control.goal = gameObject;
            }
            
        }

        if( type == "Start" )
        {
            if (control.start != null)
            {
                control.start.GetComponent<SpriteRenderer>().sprite = control.sprites[0];
                control.start.GetComponent<Floor>().type = "Normal";
                control.start = gameObject;
            }
            else
            {
                control.start = gameObject;
            }
        }
    }
    
}
