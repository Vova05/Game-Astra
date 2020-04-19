using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_game_key4 : MonoBehaviour
{
    static public bool Key_enter = false;

    private int Quanity_clik = 0;
    private void OnMouseDown()
    {
        Quanity_clik++;
      
        if (Quanity_clik == 3)
        {
            Key_enter = true;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Quanity_clik > 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            Quanity_clik = 0;
        }
    }
}
