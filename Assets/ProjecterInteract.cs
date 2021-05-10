using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecterInteract : MonoBehaviour
{
    public GameObject projector;

    public void interact()
    {
        if (projector.activeSelf == true)
            projector.SetActive(false);
        else
            projector.SetActive(true);
    }
}
