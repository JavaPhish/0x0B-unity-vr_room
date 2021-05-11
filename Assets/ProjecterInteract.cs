using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecterInteract : MonoBehaviour
{
    public GameObject projector;

    private bool unlocked = false;

    public void unlock()
    {
        unlocked = true;
        interact();
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
