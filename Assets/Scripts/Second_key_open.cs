using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_key_open: MonoBehaviour
{
    public GameObject Lock;
    public GameObject trigger;
    static public bool chek = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            chek = true;
            Destroy(other);
            Lock.GetComponent<Renderer>().material.color = Color.green;
            Destroy(trigger);
        }
    }
}
