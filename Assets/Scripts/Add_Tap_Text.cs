using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Tap_Text : MonoBehaviour
{
    public static bool trigger = false;
   private bool check=false;
    public void OnMouseDown()
    {
        if (check == false)
        {
            trigger = true;
            check = true;
        }
    }
    public void OnMouseUp()
    {
        trigger = false;
    }
}
