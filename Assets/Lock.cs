using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    public GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
        {
            door.GetComponent<DoorOpen>().unlock();
            Destroy(gameObject);
        }
    }
}
