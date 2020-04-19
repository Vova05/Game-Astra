using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_ok : MonoBehaviour
{
    public GameObject door;
    public GameObject collider_for_door;
    private void Update()
    {
        if (First_number_of_code.number_ok == true)
        {
            if (Second_number_of_code.number_ok == true)
            {
                if (Third_number_of_code.number_ok == true)
                {
                    door.SetActive(false);
                    collider_for_door.SetActive(false);
                }

            }

        }
    }
}
