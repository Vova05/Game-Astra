using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_broke : MonoBehaviour
{
    static public bool chek = false;
    private void OnMouseDrag()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseDown()
    {
        chek= true;
    }
}
