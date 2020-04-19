using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair_ware : MonoBehaviour
{
    public GameObject new_ware;
    static public bool repair = false;
    void  OnTriggerStay(Collider ware)
    {
        if (ware.tag == "Ware")
        {
            repair = true;
            new_ware.SetActive(repair);
            new_ware.GetComponent<BoxCollider>().isTrigger = true;
            Destroy(ware);
        }
        

    }
}
