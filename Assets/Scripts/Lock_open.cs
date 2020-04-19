using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock_open : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject obj2;
    static public bool trigger = false;
    bool ret = false;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Lock_card")
        {
            obj.SetActive(ret);
            obj2.SetActive(ret);
            Destroy(other);
            trigger = true;
        }
        
    }
}
