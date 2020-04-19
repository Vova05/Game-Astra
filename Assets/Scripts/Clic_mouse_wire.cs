using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clic_mouse_wire : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    
    bool ret = false;
    
    
    private void OnMouseDown()
    {

        if (ret == false&&Repair_ware.repair==true)
        {
            obj.SetActive(ret);
            obj2.SetActive(ret);
            ret = true;
        }
        else
        {
            obj.SetActive(ret);
            obj2.SetActive(true);
            ret = false;
        }
    }
}
