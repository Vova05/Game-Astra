using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_game_platform : MonoBehaviour
{
    static public bool Key=false;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Plaer")
        {
            Key = true;
        }
    }
}
