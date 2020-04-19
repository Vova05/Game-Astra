using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken_chec : MonoBehaviour
{
    static public bool destroy = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Destroer")
        {
            destroy = true;

        }

    }
}
