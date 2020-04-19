using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Click_mouse : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    bool ret = false;
    private void OnMouseDown()
    {
        
        if (ret == false)
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
