using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePuzzle : MonoBehaviour
{

    public Renderer light;
    public Material done;
    public Material empty;

    public bool isComplete = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
        {
            light.material = done;
            isComplete = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "key")
        {
            light.material = empty;
            isComplete = false;
        }
    }
}
