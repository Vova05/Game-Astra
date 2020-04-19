using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_protect_door : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj2;
    public GameObject Key;
    bool ret = false;
    private void Update()
    {
        if (ret == false&&First_key_open.chek==true&&Second_key_open.chek==true)
        {
            obj.SetActive(ret);
            obj2.SetActive(ret);
            Key.SetActive(true);
        }
        
    }

}
