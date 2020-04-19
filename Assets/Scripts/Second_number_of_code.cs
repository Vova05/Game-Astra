using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_number_of_code : MonoBehaviour
{
    static public bool number_ok = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Slider")
        {
            number_ok = true;
        }
    }
}
