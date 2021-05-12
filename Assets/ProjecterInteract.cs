using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecterInteract : MonoBehaviour
{
    public GameObject projector;

    private bool puzzle_complete = false;
    public bool unlocked = false;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    //public GameObject p2;

    public void Update()
    {
        if (puzzle_complete == false)
        {
            if (p1.GetComponent<ShapePuzzle>().isComplete
                && p2.GetComponent<ShapePuzzle>().isComplete
                && p3.GetComponent<ShapePuzzle>().isComplete
            // && p4.GetComponent<ShapePuzzle>().isComplete
            )
            {
                unlocked = true;
                interact();
                puzzle_complete = true;
            }
            else
                unlocked = false;            
        }
    }

    public void interact()
    {

        if (unlocked == true)
        {
            if (projector.activeSelf == true)
                projector.SetActive(false);
            else
                projector.SetActive(true);            
        }

    }
}
