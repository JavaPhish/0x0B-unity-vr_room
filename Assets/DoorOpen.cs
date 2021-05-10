using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Interact()
    {
        if (anim.GetBool("character_nearby") == false)
            anim.SetBool("character_nearby", true);
        else
            anim.SetBool("character_nearby", false);
    }


}
