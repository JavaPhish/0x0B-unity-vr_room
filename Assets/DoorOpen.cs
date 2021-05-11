using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;

    private bool unlocked = false;

    public GameObject wait;

    public void unlock()
    {
        unlocked = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Interact()
    {

        if (unlocked == true)
        {
            if (anim.GetBool("character_nearby") == false)
                anim.SetBool("character_nearby", true);
            else
                anim.SetBool("character_nearby", false);            
        }
        else
        {
            StartCoroutine(doorWarning());
        }
    }

    IEnumerator doorWarning()
    {
        wait.SetActive(true);
        yield return new WaitForSeconds (5);
        wait.SetActive(false);
    }
}
