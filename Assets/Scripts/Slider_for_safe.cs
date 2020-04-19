using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_for_safe : MonoBehaviour
{
    static public bool open1=false;
    static public bool open2=false;
    static public bool open3 = false;
    
    public GameObject Slider;
    
    private void OnMouseDown()
    {

        Slider.transform.position=new Vector3(transform.position.x,transform.position.y-0.05f,transform.position.z);
    }


}
